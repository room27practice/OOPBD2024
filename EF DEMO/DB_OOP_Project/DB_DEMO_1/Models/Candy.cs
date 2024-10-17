using System;
using System.Collections.Generic;

namespace DB_DEMO_1.Models
{
    public partial class Candy
    {
        public Candy()
        {

        }
        public Candy(string name, string description, int? caloriesPer100Grams, int weight, decimal? price, string? imageUrl)
        {
            Name = name;
            Description = description;
            CaloriesPer100Grams = caloriesPer100Grams;
            Weight = weight;
            Price = price;
            ImageUrl = imageUrl;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? CaloriesPer100Grams { get; set; }
        public int Weight { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; } = null!;
    }
}
