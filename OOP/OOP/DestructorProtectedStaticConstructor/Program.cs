namespace DestructorProtectedStaticConstructor
{
    internal class Program
    {
        static void Main()
        {
            var hero1 = new Hero();
            var hero2 = new Hero();
            var hero3 = new Hero(3, "Kuncho");
            var hero5 = new Hero(5, "Alisiq");

            if (true)
            {
                var hero4 = new Hero(4, "Genadi");
            }

            for (int i = 0; i < 3; i++)
            {
                var n_hero = new Hero(4, "Genadi" + i);
            }

            Console.ReadLine();
        }
    }



    public class Hero
    {
        protected string gameName;
        static int counter;
        static Hero()
        {
            Console.WriteLine("Static Consturor was summoned");
            counter = 10;
        }

        public Hero()
        {
            Console.WriteLine("New Hero was created");
        }

        public Hero(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        ~ Hero()
        {
            Console.WriteLine($"Hero with ID:{Id}. Called {Name} was killed by garbage collector.");
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}