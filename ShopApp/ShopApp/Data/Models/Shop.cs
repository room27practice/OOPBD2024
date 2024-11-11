using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace Data.Models
{
    public class Shop
    {
        public Shop()
        {
            ShopPeople = new HashSet<PersonShop>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public virtual HashSet<PersonShop> ShopPeople { get; set; }
        public virtual HashSet<Comment> Comments { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int PurposeId { get; set; }
        public virtual Purpose Purpose { get; set; }

    }
    public class Address
    {
        public Address()
        {
            Shops = new HashSet<Shop>();
        }
        public int Id { get; set; }
        public string TownName { get; set; }
        public string StreetName { get; set; }
        public string Description { get; set; }
        public int StreetNumber { get; set; }
        public virtual HashSet<Shop> Shops { get; set; }
    }
    public class Purpose
    {
        public Purpose()
        {
            Shops = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual HashSet<Shop> Shops { get; set; }
    }
    public class Person
    {
        public Person()
        {
            PersonShops = new HashSet<PersonShop>();
            Comments = new HashSet<Comment>();
        }
        public int EGN { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Proffession { get; set; }
        public decimal Budget { get; set; }

        public Gender Gender { get; set; }
        public string IzlishnoNeshto { get; set; }

        public virtual HashSet<PersonShop> PersonShops { get; set; }
        public virtual HashSet<Comment> Comments { get; set; }

    }
    public class PersonShop
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }

    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2,
        Helikopter = 3,
        Transgender = 5
        //.....
    }


    public class Comment
    {
        public Comment()
        {
            CreatedOn = DateTime.UtcNow;
            IsDeleted= false;
        }
        
        public int Id { get; set; }      
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }

        [MinLength(16),Required]
        public string Content { get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }

        
        [ForeignKey(nameof(Person))]
        public int UserEGN { get; set; }
       
        public virtual Person User { get; set; }
    }


}
