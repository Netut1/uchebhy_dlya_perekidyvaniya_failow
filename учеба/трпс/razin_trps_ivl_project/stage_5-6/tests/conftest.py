import pytest
from fastapi.testclient import TestClient

from main import app, db


@pytest.fixture(autouse=True)
def clean_storage():
    """Изоляция тестов: хранилище очищается перед каждым тестом."""
    for table in db.values():
        table.clear()
    yield


@pytest.fixture
def client():
    return TestClient(app)


@pytest.fixture
def make_source(client):
    def _make(name="nginx-access"):
        response = client.post("/sources", json={
            "name": name,
            "type": "file",
            "path_or_port": "/var/log/nginx/access.log",
            "format": "plain_text",
        })
        assert response.status_code == 201
        return response.json()["id"]
    return _make


@pytest.fixture
def ingest(client):
    def _ingest(source_id, level="INFO", message="request ok", timestamp=None):
        payload = {"source_id": source_id, "level": level, "message": message}
        if timestamp:
            payload["timestamp"] = timestamp
        response = client.post("/logs", json=payload)
        assert response.status_code == 201
        return response.json()
    return _ingest
