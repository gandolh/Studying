from email import header
from wsgiref import headers
import httpx

with httpx.Client() as client:
    r = client.get('https://example.com')
    

with httpx.Client() as client:
    headers={'X-Custom':'value'}
    r = client.get('https://httpbin.org/get',headers=headers)
    # client.post( )
    print(r.status_code, r.json())



#sharing configuration through clients
url = 'http://httpbin.org/headers'
headers = {'User-Agent':'my-app/0.0.1'}
with httpx.Client(headers=headers) as Client:
    r = client.get(url)
    print(r.json()['headers']['User-Agent'])