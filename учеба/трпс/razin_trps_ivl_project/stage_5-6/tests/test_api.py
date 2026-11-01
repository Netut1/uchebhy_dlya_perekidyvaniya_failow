def test_health(client):
    response = client.get("/health")
    assert response.status_code == 200
    assert response.json()["status"] == "ok"


def test_create_source(client):
    response = client.post("/sources", json={
        "name": "app-service", "type": "file",
        "path_or_port": "/var/log/app.log", "format": "json",
    })
    assert response.status_code == 201
    assert response.json()["name"] == "app-service"
    assert response.json()["status"] == "configured"


def test_create_source_requires_name(client):
    response = client.post("/sources", json={"type": "file", "path_or_port": "/var/log/app.log"})
    assert response.status_code == 422


def test_get_missing_source(client):
    response = client.get("/sources/does-not-exist")
    assert response.status_code == 404
