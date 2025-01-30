using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueOfLegendsLibrary.Models
{
    public class LgUser : IdentityUser
    {
        [ForeignKey(nameof(LeagueCharacter))]
        public int FavoriteCharacterId { get; set; }
        public virtual LeagueCharacter FavoriteCharacter { get; set; }
    }
}
