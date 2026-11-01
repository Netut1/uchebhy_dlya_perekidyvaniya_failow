"""Демонстрация работы ИВЛ API: источник -> логи -> поиск -> статистика.
Только стандартная библиотека. Запуск: python demo_requests.py
"""
import json
import urllib.error
import urllib.request

BASE = "http://localhost:8000"


def call(method, path, body=None):
    data = json.dumps(body).encode("utf-8") if body is not None else None
    req = urllib.request.Request(BASE + path, data=data, method=method,
                                 headers={"Content-Type": "application/json"})
    try:
        with urllib.request.urlopen(req) as resp:
            raw = resp.read().decode("utf-8")
            return resp.status, (json.loads(raw) if raw else None)
    except urllib.error.HTTPError as err:
        return err.code, json.loads(err.read().decode("utf-8"))


def show(title, result):
    status, payload = result
    print(f"\n=== {title} -> HTTP {status}")
    print(json.dumps(payload, ensure_ascii=False, indent=2))


status, source = call("POST", "/sources", {
    "name": "nginx-access", "type": "file",
    "path_or_port": "/var/log/nginx/access.log", "format": "plain_text"})
show("POST /sources", (status, source))
sid = source["id"]

for level, message in [("INFO", "GET /index 200"),
                       ("ERROR", "upstream timeout on /api/orders"),
                       ("ERROR", "disk usage above 95%")]:
    call("POST", "/logs", {"source_id": sid, "level": level, "message": message})
print("\nОтправлено 3 записи лога")

show("GET /logs/search?level=ERROR", call("GET", "/logs/search?level=ERROR"))
show("GET /logs/stats", call("GET", "/logs/stats"))
show("GET /sources/unknown (ожидаем 404)", call("GET", "/sources/unknown"))
