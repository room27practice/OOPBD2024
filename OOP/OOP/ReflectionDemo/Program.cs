using System.Linq;

namespace ReflectionDemo
{
    internal partial class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            var dog = new Dog("Sharo");
            var dog2 = new Dog("Rex");
            var person = new Person("Ivan");
            //while (true)
            //{
            //    ReflectionHelper.LaunchChosenMethodFromConsole(dog);
            //}


            var result = ReflectionHelper.CreateInstance<Dog>("Please Provide Doggy-Data for Creation:");



        }



    }
}