#import requests
#r  = requests.get('https://api.github.com/user', auth = ('user', 'pass'))

import httpx
r= httpx.get('https://api.github.com/user', auth = ('user', 'pass'))

print(r.status_code)

print(r.content)

print(r.headers['content-type'])

print(r.encoding)

print(r.json())