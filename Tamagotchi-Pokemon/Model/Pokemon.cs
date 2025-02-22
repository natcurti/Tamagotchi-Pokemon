using System.Text.Json.Serialization;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.Model;

internal class Pokemon
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public string? CapitalizedName
    {
        get
        {
            if (Name == null) return null;
            else
            {
                return CapitalizeWords.CapitalizeFirstLetter(Name);
            }
        }
    }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    public double? RealWeight
    {
        get
        {
            return (double?)this.Weight / 10;
        }
    }

    public int hunger = new Random().Next(1, 11);
    public int mood = new Random().Next(1, 11);
    public int energy =  new Random().Next(1, 11);

    [JsonPropertyName("types")]
    public List<Types>? TypesList { get; set; }

    [JsonPropertyName("stats")]
    public List<Stats>? StatsList { get; set; }

    public void ShowPokemonDetails()
    {
        Console.WriteLine("==========================");
        Console.WriteLine($"Nome: {this.CapitalizedName}");
        Console.WriteLine($"Peso: {this.RealWeight} kg");
        Console.WriteLine();
        Console.WriteLine("Tipos do Pokemon:");
        foreach(var type in TypesList!)
        {
            Console.Write($"{type.Slot} - ");
            Console.WriteLine(type.Typename!.CapitalizedName);
        }
        Console.WriteLine();
        Console.WriteLine("Estatísticas:");
        foreach(var stat in StatsList!)
        {
            Console.WriteLine($"{stat.Stat!.CapitalizedName}: {stat.StatValue}");
        }

    }

}
