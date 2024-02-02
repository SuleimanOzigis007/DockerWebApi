using AutoMapper;
using DockerWebApi.SuperHeroDto;
using DockerWebApi.SuperHeroModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Iron-Man",
                FirstName = "Tnoy",
                LastName = "Stark",
                Place = "New York",
                DateAdded = new DateTime(2001, 08, 21),
                DateModified = null
            },
             new SuperHero
            {
                Id = 1,
                Name = "Spider-Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "Queens",
                DateAdded = new DateTime(2008, 01, 11),
                DateModified = null
            },
              new SuperHero
            {
                Id = 1,
                Name = "Captain-America",
                FirstName = "Steve",
                LastName = "Rogers",
                Place = "Broklyn",
                DateAdded = new DateTime(1901, 02, 12),
                DateModified = null
            },
               new SuperHero
            {
                Id = 1,
                Name = "Thor",
                FirstName = "Thor",
                LastName = "Odinson",
                Place = "Asgard",
                DateAdded = new DateTime(2011, 08, 21),
                DateModified = null
            },
        };

        private readonly IMapper _Imapper;

        public SuperHeroController(IMapper imapper)
        {
            _Imapper = imapper;
        }

        [HttpGet]
        [Route("get-all-hero")]
        public ActionResult<List<SuperHero>> GetHero()
        {
            var mappedHeroes = superHeroes.Select(hero => _Imapper.Map<SuperHeroDtos>(hero));
            return Ok(mappedHeroes);
        }

        [HttpPost]
        [Route("add-hero")]
        public ActionResult<List<SuperHero>> AddHero(SuperHeroDtos newHero)
        {

            var hero = _Imapper.Map<SuperHero>(newHero);
            superHeroes.Add(hero);

            var mappedHeroes = superHeroes.Select(hero => _Imapper.Map<SuperHeroDtos>(hero));
            return Ok(mappedHeroes);
        }
    }
}
