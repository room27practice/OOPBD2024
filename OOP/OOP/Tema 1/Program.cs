using System.Security.Cryptography;

namespace Tema_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, 11A!");

            Product pr1 = new Product { Price = 3.43m, Name = "Orange", Ammount = 1.52 };

            Console.WriteLine("Imeto na produkta e " + pr1.Name);
            Console.WriteLine("Cenata na produkta e " + pr1.Price);//3.43

            pr1.Price = 105m;

            Console.WriteLine("Cenata na produkta e" + pr1.Price);


            Dice d1 = new Dice();//със 6 дефаултни страни
            Dice d2 = new Dice() { Sides = 5 };//със 6 дефаултни страни
            Dice d3 = new Dice() { Sides = 8 };//със 8 страни
            d2.Sides=-33

        }
    }

    class Dice
    {
        private int sides = 6;
        private string type;
        public string Name { get; set; }
        // public int Sides { get => sides; set => sides = value; }
        public int Sides
        {
            get
            {
                return 2 * sides;
            }
            set
            {
                if (value < 6)
                {
                    Console.WriteLine("Too little ammount of sides!");
                    return;
                }
                if (value > 12)
                {
                    Console.WriteLine("Do not set sides with number more than 12!");
                    return;
                }
                sides = value;
            }
        }

        public int Roll()
        {
            sides = -33;
            Sides = 3;            
            Random random = new Random();
            int result = random.Next(1, this.sides);
            return result;
        }
    }

    class Product
    {
        private string mainPic = "raz dva tri";
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Ammount { get; set; }
    }
}