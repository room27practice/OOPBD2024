using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            //int a = 1;
            //Mammal m = new Mammal("Monkey",7);

            //var p = new Intern("Purvoslav", "Tretomirov", 15);

            //p.CalculateNumbers(2, 4);

            //m.PresentYourSelf();


            string duckNames = "Kuncho Gencho Asen Ivan Makdugal";

            Duck[] ducks = duckNames.Split(" ").Select(x => new Duck(x)).ToArray();

            foreach (var d in ducks)
            {
                Console.WriteLine(d);
            }

        }
    }
}