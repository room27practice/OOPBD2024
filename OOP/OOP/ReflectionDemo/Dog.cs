namespace ReflectionDemo
{
    public class Dog
    {

        [BestForAutoCration]
        public Dog(string name)
        {
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof Woof!");
        }
    }




}