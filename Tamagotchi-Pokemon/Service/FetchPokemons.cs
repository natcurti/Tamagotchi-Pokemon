using System.Text.Json;
using Tamagotchi_Pokemon.View;
using Tamagotchi_Pokemon.Model;

namespace Tamagotchi_Pokemon.Service;
internal class FetchPokemons
{
    private readonly ListPokemons pokemons;

    public FetchPokemons(ListPokemons listPokemons)
    {
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
                        Pokemon? pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                        if (pokemon == null)
                        {
                            throw new Exception("Erro na desserialização.");
                        }
                        else
                        {
                            pokemons.AddPokemon(pokemon);
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
}
