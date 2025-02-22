using AutoMapper;
using Tamagotchi_Pokemon.Service;
using Tamagotchi_Pokemon.View;
namespace Tamagotchi_Pokemon.Controller;
internal class GameController
{
    IMapper? mapper { get; set; }
    public async Task StartGame()
    {
        
        var config = new MapperConfiguration(cfg => {
            cfg.AddProfile<AutoMapperProfile>();
        });

        mapper = config.CreateMapper();

        UserInteraction menu = new UserInteraction(mapper);
        await menu.FecthPokemonsFromAPI();
        menu.WelcomeUser();
    }
}
