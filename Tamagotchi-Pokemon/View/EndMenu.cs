namespace Tamagotchi_Pokemon.View;

internal class EndMenu : MenuBase
{
    public override void Execute(int? option = null)
    {
        Console.Clear();
        Console.WriteLine("Finalizando Tamagotchi ... ");
        Thread.Sleep(2000);
        Console.WriteLine("Seu bichinho virtual vai sentir saudades!");
        Thread.Sleep(2000);
        Console.WriteLine("Volte logo!");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }
}
