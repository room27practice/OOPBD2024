using LeagueOfLegendsLibrary.Contracts;
using LeagueOfLegendsLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueOfLegendsLibrary.Services
{
    public class LeagueCharacterService : ILeagueCharacterService
    {
        private readonly IRepository<LeagueCharacter> repo;

        public LeagueCharacterService(IRepository<LeagueCharacter> repo)
        {
            this.repo = repo;
        }
        public IQueryable<LeagueCharacter> GetQuerry() 
        {
            return repo.All().OrderBy(c=>c.Dammage);
        }

        public List<LeagueCharacter> GetAllCharacters()
        {
            return repo.All().ToList();
        }
        public LeagueCharacter GetCharacterById(int id) =>
                                        repo.All().FirstOrDefault(c => c.Id == id);
        public void Delete(int id)
        {
            var target = repo.All().FirstOrDefault(c => c.Id == id);
            if (target == null)
            {
                Console.WriteLine("Not Found Entity! Error!");
                return;
            }
            repo.Remove(target);
        }

    }
}
