from ast import main
import httpx
import requests
import time

def main_requests():
    pokemons = []
    with requests.Session() as s:
        for number in range(1,151):
                pokemon_url = f'https://pokeapi.co/api/v2/pokemon/{number}'
                resp = requests.get(pokemon_url)
                pokemons.append(resp.json()['name'])
        
        # for pokemon in pokemons:
            # print(pokemon)
start_time = time.time()

main_requests()

print(f"Requests: {time.time() - start_time} seconds")

def main_httpx():
    pokemons = []
    with httpx.Client() as client:
        for number in range(1,151):
            pokemon_url = f'https://pokeapi.co/api/v2/pokemon/{number}'
            resp = client.get(pokemon_url)
            pokemons.append(resp.json()['name'])
            
        # for pokemon in pokemons:
            # print(pokemon)

start_time = time.time()

main_httpx()

print(f"Requests: {time.time() - start_time} seconds")