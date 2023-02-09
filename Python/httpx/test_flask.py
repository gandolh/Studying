from flask import Flask
import httpx


app = Flask(__name__)

@app.route("/")
def hello():
    return "hello world"


with httpx.Client(app=app, base_url= "http://testserver") as client:
    r = client.get("/")
    print(r.text)
    assert r.status_code == 200
    assert r.text == "hello world"