using System.Text.Json.Serialization;

namespace Tamagotchi_Pokemon.Pokemons;

internal class Pokemon
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    public double? RealWeight
    {
        get
        {
            return (double?)this.Weight / 10;
        }
    }

    [JsonPropertyName("types")]
    public List<TypeInfo>? TypesList { get; set; }

    public void ShowPokemonDetails()
    {   
        Console.WriteLine($"Nome: {this.Name}");
        Console.WriteLine($"Peso: {this.RealWeight} kg");
        Console.WriteLine("Tipos do Pokemon:");
        foreach(var type in TypesList!)
        {
            Console.Write($"{type.Slot} - ");
            Console.WriteLine(type.Typename!.CapitalizedName);
        }
    }

}
