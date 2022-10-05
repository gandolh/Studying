import asyncio
from urllib import response
import httpx

async def main():
    async with httpx.AsyncClient() as client:
        response = await client.get('https://www.example.com/')
        print(response)


asyncio.run(main())

