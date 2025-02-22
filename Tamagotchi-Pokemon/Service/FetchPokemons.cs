using System.Text.Json;
using Tamagotchi_Pokemon.View;
using Tamagotchi_Pokemon.Model;
using AutoMapper;

namespace Tamagotchi_Pokemon.Service;
internal class FetchPokemons
{
    private readonly ListPokemons pokemons;
    private readonly IMapper _mapper;

    public FetchPokemons(ListPokemons listPokemons, IMapper mapper)
    {
        _mapper = mapper;
        pokemons = listPokemons;
    }

    public async Task GetPokemonsFromAPI()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    string json = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{i}/");
                    if (string.IsNullOrEmpty(json))
                    {
                        throw new Exception("Json nulo ou vazio");
                    }
                    else
                    {
                        PokemonFromApi? pokemon = JsonSerializer.Deserialize<PokemonFromApi>(json);
                        if (pokemon == null)
                        {
                            throw new Exception("Erro na desserialização.");
                        }
                        else
                        {
                            GetPokemonsDTO(pokemon);
                        }
                    }
                }
            }
            catch (HttpRequestException error)
            {
                Console.WriteLine($"Erro na requisição HTTP: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }

    public void GetPokemonsDTO(PokemonFromApi pokemon)
    {
        PokemonDto pokemonDto = _mapper.Map<PokemonDto>(pokemon);
        pokemons.AddPokemon(pokemonDto);
    }
}
