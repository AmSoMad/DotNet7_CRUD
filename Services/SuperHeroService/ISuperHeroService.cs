using DotNet7_CRUD.Models;

namespace DotNet7_CRUD.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New york City"
            },
            new SuperHero
            {
                Id = 2,
                Name = "Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu"
            }
        };
        
        List<SuperHero> GetAllHeroes();

        SuperHero? GetSingleHero(int id);
        
        List<SuperHero> AddHero(SuperHero hero);

        List<SuperHero>? UpdateHero(int id,SuperHero request);

        List<SuperHero>? DeleteHero(int id);


    }
}
