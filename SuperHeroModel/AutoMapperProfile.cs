using AutoMapper;
using DockerWebApi.SuperHeroDto;

namespace DockerWebApi.SuperHeroModel
{
   public class AutoMapperProfile : Profile
    {
        protected AutoMapperProfile()
        {
            CreateMap<SuperHero, SuperHeroDtos>();
            CreateMap<SuperHeroDtos, SuperHero>();
        }
    }
}
