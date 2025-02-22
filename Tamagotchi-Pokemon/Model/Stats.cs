using System.Text.Json.Serialization;

namespace Tamagotchi_Pokemon.Model;
internal class Stats
{
    [JsonPropertyName("base_stat")]
    public int? StatValue { get; set; }
    [JsonPropertyName("stat")]
    public StatName? Stat { get; set; }
}
