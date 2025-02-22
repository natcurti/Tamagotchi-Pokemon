using AutoMapper;
using Tamagotchi_Pokemon.Model;

namespace Tamagotchi_Pokemon.Service;

internal class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<PokemonFromApi, PokemonDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
            .ForMember(dest => dest.TypesList, opt => opt.MapFrom(src => src.TypesList))
            .ForMember(dest => dest.StatsList, opt => opt.MapFrom(src => src.StatsList));
    }

}
