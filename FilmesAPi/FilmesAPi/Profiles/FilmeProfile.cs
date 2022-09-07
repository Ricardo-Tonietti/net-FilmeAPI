using AutoMapper;

using FilmesAPi.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesAPi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}
