using Tamagotchi_Pokemon.Model;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.View;
internal class ListPokemons : MenuBase
{   
    public List<Pokemon> pokemons { get; }

    public ListPokemons()
    {
        pokemons = new List<Pokemon>();
    }

    public override void Execute(int? option = null)
    {
        ShowMenuTitle("Lista de Pokemons");
        ShowPokemonsList();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        pokemons.Add(pokemon);
    }

    public void ShowPokemonsList()
    {
        Console.WriteLine("Esses são os pokemons disponíveis para adoção: ");
        foreach (var pokemon in pokemons)
        {
            Console.WriteLine($"{pokemon.CapitalizedName}");
        }

        Console.WriteLine("Gostaria de ver detalhes de algum deles? 1 - SIM ou 2 - NÃO ");
        int option = int.Parse(Console.ReadLine()!); 
        switch(option)
        {
            case 1:
                Console.Write("Digite o nome do pokemon que deseja saber os detalhes: ");
                string pokemonName = Console.ReadLine()!;
                Pokemon? pokemon = SearchPokemon.GetPokemonFromList(pokemons, pokemonName);
                if(pokemon != null)
                {
                    pokemon.ShowPokemonDetails();
                }
                break;
            case 2:
                break;
            default:
                break;
        }

    }
}
