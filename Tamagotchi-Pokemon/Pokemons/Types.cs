using System.Text.Json.Serialization;

namespace Tamagotchi_Pokemon.Pokemons;

internal class Types
{
    [JsonPropertyName("slot")]
    public int? Slot { get; set; }

    [JsonPropertyName("type")]
    public TypeName? Typename { get; set; }
}
