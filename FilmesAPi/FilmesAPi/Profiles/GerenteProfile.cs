using AutoMapper;
using FilmesAPi.Data.Dtos.Gerente;
using FilmesAPi.Models;

namespace FilmesAPi.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}
