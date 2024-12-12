namespace CandyShop.Models
{
    public class Lolipop : Candy
    {
        public Lolipop(string name, int caloriesPer100Grams, Color color) : base(name, caloriesPer100Grams, 15)
        {
            Color = color;
        }

        public Color Color { get; set; }

        public override double MakeDentalCavity(int ageOfUser)
        {
            Console.WriteLine("Cavity no mercy");
            return 1;
        }

        public override string ToString()
        {
            return base.ToString() + $"This is Lolipop that makes cavities in tooths";
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }


    }


    public sealed class Lukche : Lolipop
    {
        public Lukche(string name, int caloriesPer100Grams, Color color) : base(name, caloriesPer100Grams, color)
        {
        }

        public override sealed void SayHello()
        {
            base.SayHello();
            Console.WriteLine("Goodbye");
        }

        public static void SravniDveNeshta<K>(K a, K b)
            where K : IComparable<K>
        {
            if (a.CompareTo(b) == 0)
            {
                Console.WriteLine("they are equal");
            }
            else if (a.CompareTo(b) > 0)
            {
                Console.WriteLine("A is greater than B");
            }
            else
            {
                Console.WriteLine("B is greater than A");
            }
        }

    }
}
