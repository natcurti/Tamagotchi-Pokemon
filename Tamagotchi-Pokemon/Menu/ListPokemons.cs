using Tamagotchi_Pokemon.Pokemons;

namespace Tamagotchi_Pokemon.Menu;
internal class ListPokemons : MenuBase
{   
    private List<Pokemon> pokemons = new List<Pokemon>();

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
        foreach (var pokemon in pokemons)
        {
            pokemon.ShowPokemonDetails();
        }
    }

    public Pokemon? GetPokemonFromList(string pokemonName)
    {   
        Pokemon? pokemonFound = pokemons.Find(pokemon => pokemon.Name!.ToUpper().Equals(pokemonName.ToUpper()));

        return (pokemonFound != null) ? pokemonFound : null;

    }
}
