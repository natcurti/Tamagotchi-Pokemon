using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.Model;

internal class PokemonDto
{
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

    public int? Weight { get; set; }

    public double? RealWeight
    {
        get
        {
            return (double?)this.Weight / 10;
        }
    }

    public List<Types>? TypesList { get; set; }

    public List<Stats>? StatsList { get; set; }

    private int hunger = new Random().Next(1, 11);
    private int mood = new Random().Next(1, 11);
    private int energy = new Random().Next(1, 11);

    public void ShowPokemonDetails()
    {
        Console.WriteLine("==========================");
        Console.WriteLine($"Nome: {this.CapitalizedName}");
        Console.WriteLine($"Peso: {this.RealWeight} kg");
        Console.WriteLine();
        Console.WriteLine("Tipos do Pokemon:");
        foreach (var type in TypesList!)
        {
            Console.Write($"{type.Slot} - ");
            Console.WriteLine(type.Typename!.CapitalizedName);
        }
        Console.WriteLine();
        Console.WriteLine("Estatísticas:");
        foreach (var stat in StatsList!)
        {
            Console.WriteLine($"{stat.Stat!.CapitalizedName}: {stat.StatValue}");
        }

    }

    public void ShowStatus()
    {
        Console.WriteLine("\n***************************");
        switch (hunger)
        {
            case < 8 and >= 5:
                Console.WriteLine($"{this.CapitalizedName} está com fome!");
                break;
            case < 5:
                Console.WriteLine($"{this.CapitalizedName} está alimentado.");
                break;
            case >= 8:
                Console.WriteLine($"{this.CapitalizedName} está faminto! Alimente-o imediatamente.");
                break;
        }

        switch (mood)
        {
            case < 6 and > 3:
                Console.WriteLine($"{this.CapitalizedName} está meio entediado. Brinque com ele.");
                break;
            case <= 3:
                Console.WriteLine($"{this.CapitalizedName} está muito triste. Você o abandonou.");
                break;
            case >= 6:
                Console.WriteLine($"{this.CapitalizedName} está feliz!");
                break;
        }

        switch (energy)
        {
            case < 6 and > 3:
                Console.WriteLine($"{this.CapitalizedName} está ficando com sono.");
                break;
            case <= 3:
                Console.WriteLine($"{this.CapitalizedName} está quase desmaiando de sono. Precisa dormir imediatamente.");
                break;
            case >= 6:
                Console.WriteLine($"{this.CapitalizedName} está descansado e cheio de energia!");
                break;
        }
        Thread.Sleep(1000);
        Console.WriteLine("***************************\n");
    }

    public void FeedPokemon()
    {
        hunger = 0;
        Console.WriteLine("\nAlimentando pokemon ...");
        Thread.Sleep(1000);
        Console.WriteLine($"{this.CapitalizedName} está alimentado! :-)\n");
        Thread.Sleep(1000);
    }

    public void PlayWithPokemon()
    {
        mood = 10;
        hunger = 5;
        Console.WriteLine($"\n{this.CapitalizedName} está feliz por você ter brincado com ele! :-)\n");
        Thread.Sleep(1000);
        Console.WriteLine("Mas agora ele está com fome.\n");
        Thread.Sleep(1000);
    }

    public void BoostEnergy()
    {
        energy = 10;
        mood = 5;
        Console.WriteLine($"\nColocando {this.CapitalizedName} para dormir.\n");
        Thread.Sleep(1000);
        Console.WriteLine($"Volte mais tarde para brincar com ele.\n");
        Thread.Sleep(1000);
    }
}
