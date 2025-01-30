using LeagueOfLegendsLibrary.Models;

namespace LeagueOfLegendsLibrary.Contracts
{
    public interface ILeagueCharacterService
    {
        void Delete(int id);
        List<LeagueCharacter> GetAllCharacters();
        LeagueCharacter GetCharacterById(int id);
        IQueryable<LeagueCharacter> GetQuerry();
    }

}
