namespace LINQ_DEMO.Models
{
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Animal(int id, string name, int age, AnimalType animalType) : this(id, name, age)
        {
            AnimalType = animalType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType AnimalType { get; set; }
    }
}