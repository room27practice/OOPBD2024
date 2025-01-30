using LeagueOfLegendsLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeagueOfLegendsLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext<LgUser, IdentityRole, string>
    {
        public DbSet<LeagueCharacter> LeagueCharacters { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{ }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
    }
}