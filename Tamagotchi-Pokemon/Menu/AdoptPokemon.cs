using Tamagotchi_Pokemon.Pokemons;

namespace Tamagotchi_Pokemon.Menu;
internal class AdoptPokemon : MenuBase
{
    private List<Pokemon> adoptedPokemons = new List<Pokemon>();

    private readonly ListPokemons pokemonsAvaliable;

    public AdoptPokemon(ListPokemons listPokemons)
    {
        pokemonsAvaliable = listPokemons;
    }

    public override void Execute(int? option = null)
    {   
        if(option == 2)
        {
            ShowMenuTitle("Adoção de Pokemons");
            Console.Write("\nDigite o nome do Pokemon que deseja adotar: ");
            string pokemonName = Console.ReadLine()!;

            Pokemon? pokemonToAdopt = pokemonsAvaliable.GetPokemonFromList(pokemonName);
        
            if(pokemonToAdopt != null)
            {
                adoptedPokemons.Add(pokemonToAdopt);
                Console.WriteLine("Carregando ...");
                Thread.Sleep(1000);
                Console.WriteLine("\nBichinho virtual adotado com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar este pokemon.\n");
            }
        } else if(option == 3)
        {
            ShowAdoptedPokemons();
        } else
        {
            return;
        }
    }

    public void ShowAdoptedPokemons()
    {
        
        if(adoptedPokemons.Count == 0)
        {
            Console.WriteLine("Você ainda não adotou nenhum pokémon! Adote um agora mesmo.");
        } else
        {
            ShowMenuTitle("Lista de Pokemons adotados:");
            foreach (var pokemon in adoptedPokemons)
            {
                Console.WriteLine($"{pokemon.CapitalizedName}");
            }
            Console.WriteLine();
        }
        
    }

}
