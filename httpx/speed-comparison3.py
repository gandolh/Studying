from ast import main
import httpx
import asyncio
import time
#wrong
async def main_httpx_wrong():
    pokemons = []
    async with httpx.AsyncClient() as client:
        for number in range(1,151):
                pokemon_url = f'https://pokeapi.co/api/v2/pokemon/{number}'
                resp = await client.get(pokemon_url)
                pokemons.append(resp.json()['name'])
        
        # for pokemon in pokemons:
            # print(pokemon)
start_time = time.time()

asyncio.run(main_httpx_wrong())

print(f"HTTPX async without tasks: {time.time() - start_time} seconds")
#good

async def get_pokemon(client, url):
    resp = await client.get(url)
    return resp.json()['name']
async def main_httpx_good():
    tasks= []
    async with httpx.AsyncClient() as client:
        for number in range(1,151):
            pokemon_url = f'https://pokeapi.co/api/v2/pokemon/{number}'
            tasks.append(asyncio.create_task(get_pokemon(client,pokemon_url)))
        pokemons = await asyncio.gather(*tasks)
        # for pokemon in pokemons:
            # print(pokemon)

start_time = time.time()

main_httpx_good()

print(f"Httpx async with tasks: {time.time() - start_time} seconds")