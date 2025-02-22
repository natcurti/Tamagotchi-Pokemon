using Tamagotchi_Pokemon.Service;

namespace Tamagotchi_Pokemon.View;

internal class UserInteraction
{   
    private readonly Dictionary<int, MenuBase> menuOptions;
    private readonly ListPokemons pokemonsList;
    private readonly FetchPokemons fetchPokemons;
    private readonly AdoptPokemon adoptPokemon;
    private readonly PokemonInteraction interactWithPokemon;
    private readonly EndMenu endApp;

    public UserInteraction()
    {
        pokemonsList = new ListPokemons();
        fetchPokemons = new FetchPokemons(pokemonsList);
        adoptPokemon = new AdoptPokemon(pokemonsList);
        interactWithPokemon = new PokemonInteraction(adoptPokemon);
        endApp = new EndMenu();
        menuOptions = new Dictionary<int, MenuBase> 
        {
            {1, pokemonsList},
            {2, adoptPokemon},
            {3, adoptPokemon},
            {4, interactWithPokemon},
            {5, endApp}
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
        Console.Clear();
        Console.WriteLine($"Olá, {NameUser} !");
        Console.WriteLine("\nEscolha entre as opções abaixo:");

        string options = $"\n1 - Acessar lista de bichinhos virtuais disponíveis" +
            $"\n2 - Adotar um bichinho virtual" +
            $"\n3 - Ver os mascotes que você já adotou" +
            $"\n4 - Interagir com seu mascote" +
            $"\n5 - Sair";

        Console.WriteLine(options);
        string input = Console.ReadLine()!;
        int option = 0;

        while (true)
        {         
            if(int.TryParse(input, out option))
            {
               if (option > 0 && option <= 5)
               {
                  MenuBase menuToShow = menuOptions[option];
                  menuToShow.Execute(option);
                  ReturnMenu();
               } 
               else
               {
                  Console.WriteLine("Opção inválida. Digite um número inteiro entre 1 e 5.");
                  input = Console.ReadLine()!;
               }

            } else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                input = Console.ReadLine()!;
            }

        }

    }

    public void ReturnMenu()
    {   
        Console.WriteLine("Digite qualquer tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }
}
