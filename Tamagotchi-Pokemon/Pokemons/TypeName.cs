using System.Text.Json.Serialization;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.Pokemons;

internal class TypeName
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public string? CapitalizedName 
    { 
        get 
        {   
            if(Name != null)
            {
                return CapitalizeFirstLetter.CapitalizeString(Name);
            } else
            {
                return null;
            }
            
        } 
    }
}
