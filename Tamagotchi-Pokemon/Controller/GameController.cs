using Tamagotchi_Pokemon.View;
namespace Tamagotchi_Pokemon.Controller;
internal class GameController
{
    public static async Task StartGame()
    {
        UserInteraction menu = new UserInteraction();
        await menu.FecthPokemonsFromAPI();
        menu.WelcomeUser();
    }
}
