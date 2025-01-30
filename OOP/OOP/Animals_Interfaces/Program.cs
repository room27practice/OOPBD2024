using System.Data.Common;

namespace Animals_Interfaces
{
    internal class Program
    {
        static void Main()
        {
            IAnimal a1 = new Dog();
            a1.Name = "Sharo";
            IInjection v1 = new Vaccine();
           a1.Annoculate(v1);

            IAnimal cat = new Cat();

        }
    }

    internal class Vaccine : IInjection
    {
        public string Name => throw new NotImplementedException();
        public double Ammount { get; set; }
    }

    internal interface IInjection
    {
        string Name { get; }
        double Ammount { get; set; }
    }

    internal class Dog : IAnimal
    {
        public string Name {get; set;}

        public void Annoculate(IInjection v1)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IAnimal
    {
        string Name { get; set; }

        void Annoculate(IInjection v1);
    }
}