namespace Comparators
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            var p1 = new Person(12, "Asen", "Chervena Gora 32", true);
            var p2 = new Person(13, "Svetoslava", "Zelen ponedelnik 67", false);
            var p3 = new Person(14, "Dobrin", "Petur Beron 13", true);
            p1.iQCoeficient = 101;
            p2.iQCoeficient = 91;
            p3.iQCoeficient = 127;

            var people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);

            Console.WriteLine(people[2].Name);
            people[2] = null;

            foreach (var p in people.OrderByDescending(x=>x.iQCoeficient))
            {
            }
        }
    }


    public class Person:IComparable<Person>
    {
        public Person(int id, string name, string address, bool gender)
        {
            Id = id;
            Name = name;
            Address = address;
            Gender = gender;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public int iQCoeficient { get; set; }

        public int CompareTo(Person? other)
        {
            if (this.iQCoeficient>other.iQCoeficient)
            {
                return 1;
            }
            else if (this.iQCoeficient == other.iQCoeficient)
            {
                return 0;
            }
            return -1;
        }      
    }
}