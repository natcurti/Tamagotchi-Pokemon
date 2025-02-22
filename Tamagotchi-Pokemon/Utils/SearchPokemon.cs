using Tamagotchi_Pokemon.Model;

namespace Tamagotchi_Pokemon.Utils;
internal class SearchPokemon
{
    public static Pokemon? GetPokemonFromList(List<Pokemon> pokemonsList, string name)
    {
        Pokemon? pokemonFound = pokemonsList.Find(pokemon => pokemon.Name!.ToUpper().Equals(name.ToUpper()));

        return (pokemonFound != null) ? pokemonFound : null;
    }
}
