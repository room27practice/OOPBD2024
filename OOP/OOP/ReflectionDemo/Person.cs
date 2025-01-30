namespace ReflectionDemo
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("New Person was created!");
        }
        public Person(string name) : this()
        {
            if (name.Length < 2)
            {
                Console.WriteLine("Error bad name!");
            }
            Name = name;
        }

        [BestForAutoCration]
        public Person(string name, int age, bool gender, string eGN) : this(name)
        {
            Age = age;
            EGN = eGN;
            Gender = gender;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string EGN { get; set; }
        public bool Gender { get; set; }

        public void DriveCar()
        {
            Console.WriteLine($"I drive my car to ! With 100 kmph.");
        }

        public int GetFavoriteNumber()
        {
            var random = new Random();
            int result = random.Next(1, 100);
            Console.WriteLine($"My favorite number is {result}");
            return result;
        }
    }




}