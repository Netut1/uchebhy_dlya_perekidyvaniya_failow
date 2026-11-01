"""Модульные тесты REST API ИВЛ (семинар 7). Фикстуры — в conftest.py."""


# ---------- система ----------
def test_health(client):
    response = client.get("/health")
    assert response.status_code == 200
    assert response.json()["status"] == "ok"


# ---------- источники логов ----------
def test_create_source(client):
    response = client.post("/sources", json={
        "name": "app-service", "type": "file",
        "path_or_port": "/var/log/app.log", "format": "json",
    })
    assert response.status_code == 201
    body = response.json()
    assert body["name"] == "app-service"
    assert body["status"] == "configured"
    assert body["id"]


def test_create_source_requires_name(client):
    response = client.post("/sources", json={"type": "file", "path_or_port": "/var/log/app.log"})
    assert response.status_code == 422


def test_create_source_rejects_unknown_type(client):
    response = client.post("/sources", json={
        "name": "bad", "type": "ftp", "path_or_port": "/x"})
    assert response.status_code == 422


def test_list_sources(client, make_source):
    make_source("nginx")
    make_source("postgres")
    response = client.get("/sources")
    assert response.status_code == 200
    assert len(response.json()) == 2


def test_get_missing_source(client):
    response = client.get("/sources/does-not-exist")
    assert response.status_code == 404
    assert response.json()["detail"] == "Source not found"


def test_delete_source_without_logs(client, make_source):
    sid = make_source()
    assert client.delete(f"/sources/{sid}").status_code == 204
    assert client.get(f"/sources/{sid}").status_code == 404


def test_delete_source_with_logs_is_conflict(client, make_source, ingest):
    sid = make_source()
    ingest(sid)
    assert client.delete(f"/sources/{sid}").status_code == 409


# ---------- приём и поиск логов ----------
def test_ingest_log(make_source, ingest):
    sid = make_source()
    entry = ingest(sid, level="ERROR", message="db timeout")
    assert entry["level"] == "ERROR"
    assert entry["source_id"] == sid
    assert entry["id"]


def test_ingest_log_unknown_source(client):
    response = client.post("/logs", json={
        "source_id": "unknown", "level": "INFO", "message": "x"})
    assert response.status_code == 404


def test_ingest_log_invalid_level(client, make_source):
    sid = make_source()
    response = client.post("/logs", json={
        "source_id": sid, "level": "FATAL", "message": "x"})
    assert response.status_code == 422


def test_search_by_level_and_text(client, make_source, ingest):
    sid = make_source()
    ingest(sid, "INFO", "user login")
    ingest(sid, "ERROR", "db timeout")
    ingest(sid, "ERROR", "disk full")

    by_level = client.get("/logs/search", params={"level": "ERROR"}).json()
    assert by_level["total"] == 2

    by_text = client.get("/logs/search", params={"query": "timeout"}).json()
    assert by_text["total"] == 1
    assert by_text["items"][0]["message"] == "db timeout"

    combined = client.get("/logs/search", params={"level": "INFO", "query": "timeout"}).json()
    assert combined["total"] == 0


def test_search_by_time_range(client, make_source, ingest):
    sid = make_source()
    ingest(sid, message="old", timestamp="2026-10-01T10:00:00Z")
    ingest(sid, message="new", timestamp="2026-10-20T10:00:00Z")
    result = client.get("/logs/search", params={"from": "2026-10-10T00:00:00Z"}).json()
    assert result["total"] == 1
    assert result["items"][0]["message"] == "new"


def test_logs_stats(client, make_source, ingest):
    sid = make_source()
    ingest(sid, "INFO")
    ingest(sid, "INFO")
    ingest(sid, "ERROR")
    stats = client.get("/logs/stats").json()
    assert stats["total"] == 3
    assert stats["by_level"]["INFO"] == 2
    assert stats["by_level"]["ERROR"] == 1
    assert stats["by_source"][sid] == 3


def test_get_log_by_id(client, make_source, ingest):
    sid = make_source()
    entry = ingest(sid, message="hello")
    response = client.get(f"/logs/{entry['id']}")
    assert response.status_code == 200
    assert response.json()["message"] == "hello"


# ---------- дашборды и виджеты ----------
def test_dashboard_with_widgets_lifecycle(client):
    created = client.post("/dashboards", json={"name": "Errors overview"})
    assert created.status_code == 201
    did = created.json()["id"]

    widget = client.post(f"/dashboards/{did}/widgets", json={
        "type": "line_chart", "query": "level:ERROR"})
    assert widget.status_code == 201

    widgets = client.get(f"/dashboards/{did}/widgets").json()
    assert len(widgets) == 1
    assert widgets[0]["type"] == "line_chart"

    assert client.delete(f"/dashboards/{did}").status_code == 204
    assert client.get(f"/dashboards/{did}").status_code == 404


def test_widget_for_missing_dashboard(client):
    response = client.post("/dashboards/unknown/widgets", json={"type": "table"})
    assert response.status_code == 404


# ---------- алертинг ----------
def test_alert_rule_creates_event_after_threshold(client, make_source, ingest):
    sid = make_source()
    rule = client.post("/alerts/rules", json={
        "name": "errors >= 2", "level": "ERROR", "threshold": 2}).json()

    ingest(sid, "ERROR", "first")
    assert client.get("/alerts/events").json() == []

    ingest(sid, "ERROR", "second")
    events = client.get("/alerts/events").json()
    assert len(events) == 1
    assert events[0]["rule_id"] == rule["id"]


def test_alert_rule_ignores_other_levels(client, make_source, ingest):
    sid = make_source()
    client.post("/alerts/rules", json={"name": "errors", "level": "ERROR"})
    ingest(sid, "INFO", "all fine")
    assert client.get("/alerts/events").json() == []


def test_alert_rule_rejects_zero_threshold(client):
    response = client.post("/alerts/rules", json={"name": "bad", "threshold": 0})
    assert response.status_code == 422


# ---------- сохранённые поиски ----------
def test_saved_search(client):
    created = client.post("/saved-searches", json={
        "name": "all errors", "query": "timeout", "level": "ERROR"})
    assert created.status_code == 201
    assert len(client.get("/saved-searches").json()) == 1
