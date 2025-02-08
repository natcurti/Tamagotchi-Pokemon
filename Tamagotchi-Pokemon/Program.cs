using System.Text.Json;
using Tamagotchi_Pokemon.Pokemons;

using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/1/");

    var pokemon = JsonSerializer.Deserialize<Pokemon>(json);

    pokemon!.ShowPokemonDetails();

}