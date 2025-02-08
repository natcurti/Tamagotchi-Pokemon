using System.Text.Json.Serialization;

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
                string firstLetter = Name.Substring(0, 1).ToUpper();
                string restOfName = Name.Substring(1);

                return $"{firstLetter}{restOfName}";
            } else
            {
                return null;
            }
            
        } 
    }
}
