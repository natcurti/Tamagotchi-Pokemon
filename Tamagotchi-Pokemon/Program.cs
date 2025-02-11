using Tamagotchi_Pokemon.Menu;

UserInteraction menu = new UserInteraction();
await menu.FecthPokemonsFromAPI();
menu.WelcomeUser();