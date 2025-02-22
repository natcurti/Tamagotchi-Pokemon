using System.Text.Json.Serialization;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.Model;
internal class PokemonFromApi
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    [JsonPropertyName("types")]
    public List<Types>? TypesList { get; set; }

    [JsonPropertyName("stats")]
    public List<Stats>? StatsList { get; set; }

}
