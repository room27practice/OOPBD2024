namespace CandyShop.Models
{
    public class Cake : Candy
    {
        //Ako tortata e 800grama po standart vinagi
        public Cake(string name, int caloriesPer100Grams, int slicesNumber, bool isVegan = false) : base(name, caloriesPer100Grams, 800)
        {
            IsVegan = isVegan;
            SliceCount = slicesNumber;
        }

        public bool IsVegan { get; set; }
        public int SliceCount { get; set; }

        public override double MakeDentalCavity(int ageOfUser)
        {
            if (ageOfUser < 10)
            {
                Console.WriteLine("No cavity chance");
                return 0.0;
            }
            else
            {
                Console.WriteLine("Inicializing new tooth cavity");
                return 3.14 * ageOfUser / 100;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nThis is Cake with {SliceCount} slices";
        }
    }
}
