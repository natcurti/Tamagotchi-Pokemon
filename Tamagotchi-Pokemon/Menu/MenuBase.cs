namespace Tamagotchi_Pokemon.Menu;
internal class MenuBase
{
    public void ShowMenuTitle(string title)
    {   
        int titleLength = title.Length;
        string asterisks = string.Empty.PadLeft(titleLength, '*');
        Console.WriteLine();
        Console.WriteLine(asterisks);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(asterisks);
    }

    public virtual void Execute(){}
}
