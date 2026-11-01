"""ИВЛ API — REST-прототип инструмента визуализации логов (вариант 21).
Разин Д.Д., группа ИДБ-25-06. Семинары ТРПС 5–6.
"""
from datetime import datetime, timezone
from enum import Enum
from typing import Optional
from uuid import uuid4

from fastapi import FastAPI, HTTPException, Query
from pydantic import BaseModel, Field

app = FastAPI(
    title="ИВЛ API — Разин Д.Д. (семинары ТРПС)",
    version="1.0.0",
    description="REST API инструмента визуализации логов (ИВЛ), вариант 21: "
                "источники, логи, дашборды, алерты, сохранённые поиски.",
)


# ---------- Перечисления ----------
class LogLevel(str, Enum):
    DEBUG = "DEBUG"
    INFO = "INFO"
    WARNING = "WARNING"
    ERROR = "ERROR"
    CRITICAL = "CRITICAL"


class SourceType(str, Enum):
    file = "file"
    tcp = "tcp"
    udp = "udp"
    syslog = "syslog"
    gelf = "gelf"


class SourceFormat(str, Enum):
    json = "json"
    syslog = "syslog"
    plain_text = "plain_text"
    regex = "regex"


class WidgetType(str, Enum):
    line_chart = "line_chart"
    bar_chart = "bar_chart"
    histogram = "histogram"
    table = "table"


class Severity(str, Enum):
    low = "low"
    medium = "medium"
    high = "high"
    critical = "critical"


class Channel(str, Enum):
    email = "email"
    slack = "slack"
    telegram = "telegram"
    webhook = "webhook"


# ---------- Хранилище в памяти (учебный вариант) ----------
db = {
    "sources": {},
    "logs": {},
    "dashboards": {},
    "widgets": {},
    "alert_rules": {},
    "alert_events": {},
    "saved_searches": {},
}


def now() -> datetime:
    return datetime.now(timezone.utc)


def new_id() -> str:
    return str(uuid4())


def to_utc(dt: datetime) -> datetime:
    if dt.tzinfo is None:
        return dt.replace(tzinfo=timezone.utc)
    return dt.astimezone(timezone.utc)


def get_or_404(table: str, item_id: str, label: str) -> dict:
    item = db[table].get(item_id)
    if item is None:
        raise HTTPException(status_code=404, detail=f"{label} not found")
    return item


# ---------- Схемы запросов ----------
class SourceIn(BaseModel):
    name: str = Field(min_length=1, max_length=120)
    type: SourceType
    path_or_port: str
    format: SourceFormat = SourceFormat.json


class LogIn(BaseModel):
    source_id: str
    level: LogLevel
    message: str = Field(min_length=1)
    timestamp: Optional[datetime] = None
    fields_json: dict = Field(default_factory=dict)


class DashboardIn(BaseModel):
    name: str = Field(min_length=1, max_length=120)
    description: str = ""
    owner: str = "admin"


class WidgetIn(BaseModel):
    type: WidgetType
    query: str = ""
    config_json: dict = Field(default_factory=dict)


class AlertRuleIn(BaseModel):
    name: str = Field(min_length=1, max_length=120)
    level: LogLevel = LogLevel.ERROR
    keyword: Optional[str] = None
    threshold: int = Field(default=1, ge=1)
    severity: Severity = Severity.high
    channel: Channel = Channel.telegram
    enabled: bool = True


class SavedSearchIn(BaseModel):
    name: str = Field(min_length=1, max_length=120)
    query: str = ""
    level: Optional[LogLevel] = None
    source_id: Optional[str] = None


# ---------- Логика алертинга (FR-9) ----------
def evaluate_alerts(entry: dict) -> None:
    for rule in db["alert_rules"].values():
        if not rule["enabled"] or rule["level"] != entry["level"]:
            continue
        keyword = rule["keyword"]
        if keyword and keyword.lower() not in entry["message"].lower():
            continue
        rule["matched"] += 1
        if rule["matched"] >= rule["threshold"]:
            rule["matched"] = 0
            eid = new_id()
            db["alert_events"][eid] = {
                "id": eid,
                "rule_id": rule["id"],
                "log_entry_id": entry["id"],
                "timestamp": now(),
                "severity": rule["severity"],
                "channel": rule["channel"],
                "status": "sent",
            }


# ================= МАРШРУТЫ =================
@app.get("/health", tags=["system"])
def health():
    return {"status": "ok", "time": now()}


# ---------- Источники логов (FR-11) ----------
@app.post("/sources", status_code=201, tags=["sources"])
def create_source(body: SourceIn):
    sid = new_id()
    db["sources"][sid] = {
        "id": sid,
        **body.model_dump(mode="json"),
        "status": "configured",
        "created_at": now(),
    }
    return db["sources"][sid]


@app.get("/sources", tags=["sources"])
def list_sources():
    return list(db["sources"].values())


@app.get("/sources/{source_id}", tags=["sources"])
def get_source(source_id: str):
    return get_or_404("sources", source_id, "Source")


@app.delete("/sources/{source_id}", status_code=204, tags=["sources"])
def delete_source(source_id: str):
    get_or_404("sources", source_id, "Source")
    if any(log["source_id"] == source_id for log in db["logs"].values()):
        raise HTTPException(status_code=409, detail="Source has stored logs")
    del db["sources"][source_id]


# ---------- Логи: приём, поиск, статистика (FR-1, FR-5, FR-6, FR-7) ----------
@app.post("/logs", status_code=201, tags=["logs"])
def ingest_log(body: LogIn):
    get_or_404("sources", body.source_id, "Source")
    lid = new_id()
    entry = {
        "id": lid,
        "timestamp": to_utc(body.timestamp) if body.timestamp else now(),
        "source_id": body.source_id,
        "level": body.level.value,
        "message": body.message,
        "fields_json": body.fields_json,
    }
    db["logs"][lid] = entry
    evaluate_alerts(entry)
    return entry


@app.get("/logs/search", tags=["logs"])
def search_logs(
    query: Optional[str] = None,
    level: Optional[LogLevel] = None,
    source_id: Optional[str] = None,
    date_from: Optional[datetime] = Query(None, alias="from"),
    date_to: Optional[datetime] = Query(None, alias="to"),
    limit: int = Query(100, ge=1, le=1000),
):
    items = list(db["logs"].values())
    if query:
        items = [x for x in items if query.lower() in x["message"].lower()]
    if level:
        items = [x for x in items if x["level"] == level.value]
    if source_id:
        items = [x for x in items if x["source_id"] == source_id]
    if date_from:
        items = [x for x in items if x["timestamp"] >= to_utc(date_from)]
    if date_to:
        items = [x for x in items if x["timestamp"] <= to_utc(date_to)]
    items.sort(key=lambda x: x["timestamp"], reverse=True)
    return {"total": len(items), "items": items[:limit]}


@app.get("/logs/stats", tags=["logs"])
def logs_stats():
    by_level = {lvl.value: 0 for lvl in LogLevel}
    by_source = {}
    for log in db["logs"].values():
        by_level[log["level"]] += 1
        by_source[log["source_id"]] = by_source.get(log["source_id"], 0) + 1
    return {"total": len(db["logs"]), "by_level": by_level, "by_source": by_source}


@app.get("/logs/{log_id}", tags=["logs"])
def get_log(log_id: str):
    return get_or_404("logs", log_id, "Log")


# ---------- Дашборды и виджеты (FR-8) ----------
@app.post("/dashboards", status_code=201, tags=["dashboards"])
def create_dashboard(body: DashboardIn):
    did = new_id()
    db["dashboards"][did] = {"id": did, **body.model_dump(), "created_at": now()}
    return db["dashboards"][did]


@app.get("/dashboards", tags=["dashboards"])
def list_dashboards():
    return list(db["dashboards"].values())


@app.get("/dashboards/{dashboard_id}", tags=["dashboards"])
def get_dashboard(dashboard_id: str):
    return get_or_404("dashboards", dashboard_id, "Dashboard")


@app.delete("/dashboards/{dashboard_id}", status_code=204, tags=["dashboards"])
def delete_dashboard(dashboard_id: str):
    get_or_404("dashboards", dashboard_id, "Dashboard")
    del db["dashboards"][dashboard_id]
    for wid in [w["id"] for w in db["widgets"].values() if w["dashboard_id"] == dashboard_id]:
        del db["widgets"][wid]


@app.post("/dashboards/{dashboard_id}/widgets", status_code=201, tags=["dashboards"])
def add_widget(dashboard_id: str, body: WidgetIn):
    get_or_404("dashboards", dashboard_id, "Dashboard")
    wid = new_id()
    db["widgets"][wid] = {"id": wid, "dashboard_id": dashboard_id, **body.model_dump(mode="json")}
    return db["widgets"][wid]


@app.get("/dashboards/{dashboard_id}/widgets", tags=["dashboards"])
def list_widgets(dashboard_id: str):
    get_or_404("dashboards", dashboard_id, "Dashboard")
    return [w for w in db["widgets"].values() if w["dashboard_id"] == dashboard_id]


# ---------- Алертинг (FR-9, FR-10) ----------
@app.post("/alerts/rules", status_code=201, tags=["alerts"])
def create_rule(body: AlertRuleIn):
    rid = new_id()
    db["alert_rules"][rid] = {"id": rid, **body.model_dump(mode="json"), "matched": 0}
    return db["alert_rules"][rid]


@app.get("/alerts/rules", tags=["alerts"])
def list_rules():
    return list(db["alert_rules"].values())


@app.delete("/alerts/rules/{rule_id}", status_code=204, tags=["alerts"])
def delete_rule(rule_id: str):
    get_or_404("alert_rules", rule_id, "Rule")
    del db["alert_rules"][rule_id]


@app.get("/alerts/events", tags=["alerts"])
def list_events():
    return list(db["alert_events"].values())


# ---------- Сохранённые поиски (FR-5) ----------
@app.post("/saved-searches", status_code=201, tags=["saved-searches"])
def create_saved_search(body: SavedSearchIn):
    sid = new_id()
    db["saved_searches"][sid] = {"id": sid, **body.model_dump(mode="json")}
    return db["saved_searches"][sid]


@app.get("/saved-searches", tags=["saved-searches"])
def list_saved_searches():
    return list(db["saved_searches"].values())
