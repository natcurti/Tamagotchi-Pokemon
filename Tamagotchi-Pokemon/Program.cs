using Tamagotchi_Pokemon.Menu;
using Tamagotchi_Pokemon.Pokemons;


UserInteraction menu = new UserInteraction();
await menu.FecthPokemonsFromAPI();
menu.WelcomeUser();