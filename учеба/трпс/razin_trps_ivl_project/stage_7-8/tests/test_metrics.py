"""Тесты мониторинга (семинар 8): endpoint /metrics и бизнес-метрики."""
from prometheus_client import REGISTRY


def sample(name, labels=None):
    return REGISTRY.get_sample_value(name, labels or {}) or 0.0


def test_metrics_endpoint_exposes_http_metrics(client):
    client.get("/health")
    response = client.get("/metrics")
    assert response.status_code == 200
    assert "ivl_http_requests_total" in response.text
    assert 'path="/health"' in response.text
    assert "ivl_http_request_duration_seconds_bucket" in response.text


def test_metrics_endpoint_does_not_count_itself(client):
    client.get("/metrics")
    assert 'path="/metrics"' not in client.get("/metrics").text


def test_unknown_route_is_labelled_unmatched(client):
    assert client.get("/no-such-route").status_code == 404
    assert 'path="unmatched"' in client.get("/metrics").text


def test_ingest_updates_business_metrics(make_source, ingest):
    before = sample("ivl_logs_ingested_total", {"level": "ERROR"})
    sid = make_source()
    ingest(sid, "ERROR", "boom")
    assert sample("ivl_logs_ingested_total", {"level": "ERROR"}) == before + 1
    assert sample("ivl_logs_stored") == 1


def test_alert_event_increments_alert_counter(client, make_source, ingest):
    before = sample("ivl_alert_events_total", {"severity": "critical"})
    sid = make_source()
    client.post("/alerts/rules", json={
        "name": "any error", "level": "ERROR", "severity": "critical"})
    ingest(sid, "ERROR", "boom")
    assert sample("ivl_alert_events_total", {"severity": "critical"}) == before + 1
