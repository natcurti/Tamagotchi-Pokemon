using System.Text.Json.Serialization;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.Model;

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
                return CapitalizeWords.CapitalizeFirstLetter(Name);
            } else
            {
                return null;
            }
            
        } 
    }
}
