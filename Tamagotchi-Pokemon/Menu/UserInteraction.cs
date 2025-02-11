using Tamagotchi_Pokemon.Pokemons;

namespace Tamagotchi_Pokemon.Menu;

internal class UserInteraction
{   
    private readonly Dictionary<int, MenuBase> menuOptions;
    private readonly DisplayPokemons displayPokemons;
    private readonly FetchPokemons fetchPokemons;

    public UserInteraction()
    {
        displayPokemons = new DisplayPokemons();
        fetchPokemons = new FetchPokemons(displayPokemons);
        menuOptions = new Dictionary<int, MenuBase> 
        {
            {1, displayPokemons}
        };
    }
    public string? NameUser { get; set; }

    public async Task FecthPokemonsFromAPI()
    {
        await fetchPokemons.GetPokemonsFromAPI();
    }
    public void WelcomeUser()
    {
        Console.WriteLine("Bem-vindo(a) ao Mundo dos Bichinhos Virtuais!");
        Console.WriteLine(@"
████████╗░█████╗░███╗░░░███╗░█████╗░░██████╗░░█████╗░████████╗░█████╗░██╗░░██╗██╗
╚══██╔══╝██╔══██╗████╗░████║██╔══██╗██╔════╝░██╔══██╗╚══██╔══╝██╔══██╗██║░░██║██║
░░░██║░░░███████║██╔████╔██║███████║██║░░██╗░██║░░██║░░░██║░░░██║░░╚═╝███████║██║
░░░██║░░░██╔══██║██║╚██╔╝██║██╔══██║██║░░╚██╗██║░░██║░░░██║░░░██║░░██╗██╔══██║██║
░░░██║░░░██║░░██║██║░╚═╝░██║██║░░██║╚██████╔╝╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║██║
░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚═════╝░░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝");
        Console.Write("Qual o seu nome? ");
        string? user = Console.ReadLine();
        NameUser = user;
        ShowMenu();
    }

    public void ShowMenu()
    {
        Console.WriteLine($"Bem-vindo(a), {NameUser}");
        Console.WriteLine("\nEscolha entre as opções abaixo:");

        string options = $"\n1 - Acessar lista de bichinhos virtuais disponíveis" +
            $"\n2 - Adotar um bichinho virtual" +
            $"\n3 - Ver os mascotes que você já adotou" +
            $"\n4 - Interagir com seu mascote" +
            $"\n5 - Sair";

        Console.WriteLine(options);
        int option = int.Parse(Console.ReadLine()!);
        if (menuOptions.ContainsKey(option))
        {
            MenuBase menuToShow = menuOptions[option];
            menuToShow.Execute();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }
}
