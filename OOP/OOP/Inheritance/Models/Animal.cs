using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string SpeciesName { get; set; }
        public int Age { get; set; }
        public int LifeSpanLimit { get; set; }
        public double Weight { get; set; }
        public int CountOfEyes { get; set; }
        public Habitat Habitat { get; set; }

        //public Animal()
        //{
        //    Console.WriteLine("Animal was created !");
        //}

        public Animal(string speciesName)// : this()
        {
            SpeciesName = speciesName;
        }
        public Animal(string speciesName, int age, double weight, int lifeSpanLimit, int countOfEyes) : this(speciesName)
        {
            Age = age;
            Weight = weight;
            LifeSpanLimit = lifeSpanLimit;
            CountOfEyes = countOfEyes;
        }


        public void PresentYourSelf()
        {
            Console.WriteLine($"I am {SpeciesName}. I am {Age} years old. I weight {Weight} kgs.");
        }
    }

    public class Birds
    {
        public int Id { get; set; }
        public string SpeciesName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int LifeSpanLimit { get; set; }
        public int CountOfEyes { get; set; }

        public double EggSizeRadiusMax { get; set; }
    }

    public class Dog
    {

    }


    public enum Habitat
    {
        Ocean, Land, Air
    }
}
