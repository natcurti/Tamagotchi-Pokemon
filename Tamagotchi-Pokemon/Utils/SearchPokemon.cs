using Tamagotchi_Pokemon.Model;

namespace Tamagotchi_Pokemon.Utils;
internal class SearchPokemon
{
    public static PokemonDto? GetPokemonFromList(List<PokemonDto> pokemonsList, string name)
    {
        PokemonDto? pokemonFound = pokemonsList.Find(pokemon => pokemon.CapitalizedName!.ToUpper().Equals(name.ToUpper()));

        return (pokemonFound != null) ? pokemonFound : null;
    }
}
