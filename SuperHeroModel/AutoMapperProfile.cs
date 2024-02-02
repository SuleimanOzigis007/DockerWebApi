using AutoMapper;
using DockerWebApi.SuperHeroDto;

namespace DockerWebApi.SuperHeroModel
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SuperHero, SuperHeroDtos>();
            CreateMap<SuperHeroDtos, SuperHero>();
        }
    }
}
