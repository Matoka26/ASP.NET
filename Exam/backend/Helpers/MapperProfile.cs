using backend.Models;
using backend.Models.DTOs;

namespace backend.Helpers;

public class MapperProfile : AutoMapper.Profile
{
    public MapperProfile()
    {
        CreateMap<Editura, EdituraDTO>();
        CreateMap<EdituraDTO, Editura>();

        CreateMap<Autor, AutorDTO>();
        CreateMap<AutorDTO, Autor>();

        CreateMap<CarteDTO, Carte>();
        CreateMap<Carte, CarteDTO>();

        CreateMap<AutorCarteRelatie, RelatieDTO>();
        CreateMap<RelatieDTO, AutorCarteRelatie>();
    }
}