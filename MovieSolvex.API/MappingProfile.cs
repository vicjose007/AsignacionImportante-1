using AutoMapper;
using MovieSolvex.Domain;

namespace MovieSolvex.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MovieSolvexRequest, Movie>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Nombre));

            CreateMap<MovieSolvexRequest, Movie>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Identificacion));

            CreateMap<MovieSolvexRequest, Movie>()
                .ForMember(d => d.Price, o => o.MapFrom(s => s.precio));

            CreateMap<MovieSolvexRequest, Movie>()
                .ForMember(d => d.DateTime, o => o.MapFrom(s => s.Fecha));

            CreateMap<MovieSolvexRequest, Movie>()
                .ForMember(d => d.Director, o => o.MapFrom(s => s.DirectorDeCine));

        }
    }
}
