using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Engine
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PersonShop> PersonShops { get; set; }

        public ShopDbContext()
        { }
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-H86OA8E\\SQLEXPRESS;Database=ShopDBRoom27_11A;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Наши правила как да се направи базата
            modelBuilder.Entity<Person>().HasKey(x => x.EGN);//трябва да кажем кой е ключа
            modelBuilder.Entity<Person>().Ignore(x => x.IzlishnoNeshto);//няма да се създаде колона в базата!
                                                                        // modelBuilder.Entity<Shop>().HasKey(x => x.Id); досеща се и без наша помощ
            modelBuilder.Entity<PersonShop>().HasKey(x => new { x.ShopId, x.PersonId });//дефинираме композитен ключ
        }
    }
}
