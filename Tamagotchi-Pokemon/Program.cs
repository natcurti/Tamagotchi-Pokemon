using System.Text.Json;
using Tamagotchi_Pokemon.Pokemons;

using (HttpClient client = new HttpClient())
{   
    for(int i = 1; i <= 5; i++)
    {
        string json = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{i}/");

        var pokemon = JsonSerializer.Deserialize<Pokemon>(json);

        pokemon!.ShowPokemonDetails();

    }    

}