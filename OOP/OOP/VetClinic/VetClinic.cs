namespace VetClinic
{
    public class VetClinic
    {

        private decimal profit = 0;

        private List<Animal> sickAnimals =
            new List<Animal>();

        public List<Animal>
            HealedAnimals
        { get; set; } = new List<Animal>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public void RegisterPet(string name, string animalType, string illness, decimal price)
        {
            var newAnimal = new Animal() { Name = name, AnimalType = animalType, Illness = illness, Price = price };
            sickAnimals.Add(newAnimal);
        }

        public void CurePatient()
        {
            #region exampleWithForeach
            //int index = -1;
            //foreach (Animal patient in sickAnimals)
            //{
            //    index++;
            //    Console.WriteLine($"{index} - {patient.Name} - {patient.AnimalType} [{patient.Illness}]");
            //}
            #endregion
            for (int i = 0; i < sickAnimals.Count() / 2; i++)
            {
                var animalFd = sickAnimals[i];
                Console.WriteLine($"{i} - {animalFd.Name} - {animalFd.AnimalType} [{animalFd.Illness}]");
            }
            Console.Write("Please select sick animal Index to be cured:...");
            int indexChosen = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Animal selectedAnimal = sickAnimals[indexChosen];
            Console.WriteLine($"Congratulations animal {selectedAnimal.Name} was cured.\n It has no more {selectedAnimal.Illness}");
            selectedAnimal.Illness = null;
            profit += selectedAnimal.Price;
            selectedAnimal.Price = 0;
            sickAnimals.Remove(selectedAnimal);
            HealedAnimals.Add(selectedAnimal);
        }


        public decimal TaxRevenue()
        {
            return profit * 0.15m;
        }

        public decimal Tax { get
            {
                return profit * 0.15m;
            }
        }

        public decimal NegativeTax
        {
            get
            {
                return -profit * 0.15m;
            }
        }

    }

}
