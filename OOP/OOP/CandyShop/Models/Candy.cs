using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public abstract class Candy
    {
        protected Candy(string name, int caloriesPer100Grams, double weightGrams)
        {
            Name = name;
            CaloriesPer100Grams = caloriesPer100Grams;
            WeightGrams = weightGrams;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CaloriesPer100Grams { get; set; }
        public double WeightGrams { get; set; }
        public double GetTotalCalories { get => WeightGrams * CaloriesPer100Grams / 100; }

        public abstract double MakeDentalCavity(int ageOfUser);

        public override string ToString()
        {
            return $"This is Candy: {Name}. With Id: {Id}";
        }
    }
}
