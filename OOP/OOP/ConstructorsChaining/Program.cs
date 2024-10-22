
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ConstructorsChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Desk d1 = new Desk();
            Console.WriteLine(new string('=', 20));

            Desk d2 = new Desk(7);
            Console.WriteLine(new string('=', 20));

            Desk d3 = new Desk(7, "Mnogo hubavo oranjevo biuro");



            Desk d4 = new Desk();



        }
    }
    public class Desk
    {
        private static int counter = 0;

        public Desk()
        {
            Id = ++counter;
            Console.WriteLine("Congratulations new instance was made!");
            Console.WriteLine("A");
        }
        public Desk(int weight) : this()
        {
            Console.WriteLine("B");
            Weight = weight;
        }

        public Desk(int weight, string desc) : this(weight)
        {
            Console.WriteLine("C");

            Description = desc;
        }

        public Desk(int weight, string desc, Color color, Material mat) : this(weight, desc)
        {
            Color = color;
            Material = mat;
        }

        public Desk(int weight, string desc, string color = "White", string mat = "Glass") : this(weight, desc)
        {
            Color colorRead;
            if (Enum.TryParse<Color>(color, true, out colorRead))
            {
                Color = colorRead;
            }
            else
            {
                Console.WriteLine("Nevaliden cviat!");
                Color = Color.White;//po podrazbirane
            }

            Material materialRead;
            if (Enum.TryParse<Material>(color, true, out materialRead))
            {
                Material = materialRead;
            }
            else
            {
                Console.WriteLine("Nevaliden material!");
                Material = Material.Wood;//po podrazbirane
            }


        }


        public int Id { get; set; }
        public Color Color { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public Material Material { get; set; }
        public int SeatsCount { get; set; } = 1;
        public decimal Price { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

    }

    public class Manufacturer
    {
        public Manufacturer()
        {
            Console.WriteLine("A");
            Desks = new List<Desk>();
        }

        public Manufacturer(int id, string name) : this()
        {
            Console.WriteLine("B");
            Id = id;
            Name = name;
        }

        public Manufacturer(int id, string name, string address) : this(id, name)
        {
            Console.WriteLine("C");
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual IList<Desk> Desks { get; set; }
    }






    public enum Material
    {
        Undefined,Wood, Glass, Steal, Plastic, Carbone, Fibroglass, Rubber

    }

    public enum Color
    {
        Undefined, White, Orange, Brown, Black

    }
}