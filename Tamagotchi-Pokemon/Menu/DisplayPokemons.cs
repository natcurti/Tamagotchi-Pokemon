using Tamagotchi_Pokemon.Pokemons;

namespace Tamagotchi_Pokemon.Menu;
internal class DisplayPokemons : MenuBase
{   
    private List<Pokemon> pokemonsList = new List<Pokemon>();

    public override void Execute()
    {
        ShowMenuTitle("Lista de Pokemons");
        ShowPokemonsList();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        pokemonsList.Add(pokemon);
    }

    public void ShowPokemonsList()
    {
        foreach (var pokemon in pokemonsList)
        {
            pokemon.ShowPokemonDetails();
        }
    }
}
