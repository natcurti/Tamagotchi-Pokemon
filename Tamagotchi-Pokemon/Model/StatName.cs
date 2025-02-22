using System.Text.Json;
using System.Text.Json.Serialization;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.Model;
internal class StatName
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public string? CapitalizedName
    {
        get
        {
            if(Name != null)
            {
                return CapitalizeWords.CapitalizeAllLetters(Name);
            } else
            {
                return null;
            }
        }
    }
}
