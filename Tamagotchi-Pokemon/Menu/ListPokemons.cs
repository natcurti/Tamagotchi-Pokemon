using Tamagotchi_Pokemon.Pokemons;

namespace Tamagotchi_Pokemon.Menu;
internal class ListPokemons : MenuBase
{   
    private List<Pokemon> pokemonsList = new List<Pokemon>();

    public void Execute()
    {
        ShowMenuTitle("Lista de Pokemons");
    }

    public void AddPokemon(Pokemon pokemon)
    {
        pokemonsList.Add(pokemon);
    }
}
