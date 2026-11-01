"""Генератор нагрузки для ИВЛ API: наполняет метрики Prometheus/Grafana.
Только стандартная библиотека. Запуск: python load_traffic.py [число_раундов]
"""
import json
import random
import sys
import time
import urllib.error
import urllib.request

BASE = "http://localhost:8000"
LEVELS = ["DEBUG", "INFO", "INFO", "INFO", "WARNING", "ERROR", "CRITICAL"]
MESSAGES = ["GET /index 200", "upstream timeout", "disk usage above 90%",
            "user login", "cache miss", "payment failed"]


def call(method, path, body=None):
    data = json.dumps(body).encode("utf-8") if body is not None else None
    req = urllib.request.Request(BASE + path, data=data, method=method,
                                 headers={"Content-Type": "application/json"})
    try:
        with urllib.request.urlopen(req) as resp:
            raw = resp.read().decode("utf-8")
            return resp.status, (json.loads(raw) if raw else None)
    except urllib.error.HTTPError as err:
        return err.code, None


rounds = int(sys.argv[1]) if len(sys.argv) > 1 else 5
status, source = call("POST", "/sources", {
    "name": "load-test", "type": "tcp", "path_or_port": "5140", "format": "json"})
sid = source["id"]
call("POST", "/alerts/rules", {"name": "critical errors", "level": "CRITICAL",
                               "severity": "critical", "threshold": 2})
call("POST", "/dashboards", {"name": "Load test dashboard"})

sent = errors = 0
for r in range(1, rounds + 1):
    for _ in range(20):
        status, _ = call("POST", "/logs", {"source_id": sid, "level": random.choice(LEVELS),
                                           "message": random.choice(MESSAGES)})
        sent += 1
    call("GET", "/logs/search?level=ERROR")
    call("GET", "/logs/stats")
    call("GET", "/sources/unknown")                       # 404 -> метрика 4xx
    call("POST", "/logs", {"source_id": sid, "level": "FATAL", "message": "x"})  # 422
    errors += 2
    print(f"раунд {r}/{rounds}: отправлено {sent} логов, ошибочных запросов {errors}")
    time.sleep(2)

status, events = call("GET", "/alerts/events")
print(f"готово: логов {sent}, сработавших алертов {len(events)}")
