from email import header
import json
import httpx

# simple api
r = httpx.get('https://httpbin.org/get')

r = httpx.post('https://httpbin.org/get', data={'key':'value'})
r = httpx.put('https://httpbin.org/put', data={'key':'value'})
r = httpx.delete('https://httpbin.org/delete')
r = httpx.head('https://httpbin.org/get')
r = httpx.options('https://httpbin.org/get')


# Pass Parameters
params = {'key1':'value1', 'key2': 'value2'}
r = httpx.get('https://httpbin.org/get', params= params)

# Custom headers
headers = {'user-agent':'my-app/0.0.1'}
r = httpx.get('https://httpbin.org/headers', headers=headers)

# Send json encoded data
data = {'integer':123, 'boolean': True, 'list': ['a','b','c']}
r= httpx.post('https://httpbin.org/post',json=json)

# Cookies
r = httpx.get('https://httpbin.org/cookies/set?chocolate=chip')
print(r.cookies['chocolate'])

# Authentication
httpx.get("https://example.com", auth=("my_user", "password123"))

#timeout
httpx.get('https://github.com/',timeout=1)

