using Tamagotchi_Pokemon.Controller;

internal class Program
{
    private static async Task Main(string[] args)
    {
        GameController game = new GameController(); 
        await game.StartGame();
    }
}