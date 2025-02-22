using Tamagotchi_Pokemon.Model;
using Tamagotchi_Pokemon.Utils;

namespace Tamagotchi_Pokemon.View;
internal class PokemonInteraction : MenuBase
{
    private AdoptPokemon adoptPokemon;
    private Pokemon pokemonToInteract = new();

    public PokemonInteraction(AdoptPokemon adoptPokemonMenu)
    {
        adoptPokemon = adoptPokemonMenu;
    }
    public override void Execute(int? option = null)
    {
        ShowMenuTitle($"Hora de cuidar do seu bichinho virtual!");
        Console.Write("Digite o nome do bichinho que deseja cuidar: ");
        string pokemonName = Console.ReadLine()!;

        Pokemon? pokemon = SearchPokemon.GetPokemonFromList(adoptPokemon.adoptedPokemons, pokemonName);
        if(pokemon != null)
        {
            pokemonToInteract = pokemon;
            ShowMenuToInteractWithPokemon();
        } else
        {
            Console.WriteLine("Não foi encontrado este pokemon na sua lista de mascotes adotados.");
        }
    }

    public void ShowMenuToInteractWithPokemon()
    {
        Console.WriteLine("IMPLEMENTAR MENU DE INTERAÇÃO. ");
    }


}
