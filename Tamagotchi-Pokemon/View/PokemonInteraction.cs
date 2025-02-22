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
        bool back = false;

        while (!back)
        {
            Console.WriteLine("Você gostaria de: ");
            Console.WriteLine($"1 - Saber como {this.pokemonToInteract.CapitalizedName} está");
            Console.WriteLine($"2 - Alimentar {this.pokemonToInteract.CapitalizedName}");
            Console.WriteLine($"3 - Brincar com {this.pokemonToInteract.CapitalizedName}");
            Console.WriteLine($"4 - Colocar {this.pokemonToInteract.CapitalizedName} para dormir");
            Console.WriteLine($"5 - Sair");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        pokemonToInteract.ShowStatus();
                        break;
                    case 2:
                        pokemonToInteract.FeedPokemon();
                        break;
                    case 3:
                        pokemonToInteract.PlayWithPokemon();
                        break;
                    case 4:
                        pokemonToInteract.BoostEnergy();
                        break;
                    case 5:
                        back = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida, digite um número de 1 a 5.");
            }          

        }
        
    }


}
