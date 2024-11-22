namespace Inheritance.Models
{
    public class Mammal : Animal
    {

        public Mammal(string speciesName,int monthsMilkDrinking):base(speciesName, 15,12.5,15,2)
        {
            MonthsOfMilkFeeding = monthsMilkDrinking;

        }
        public int MonthsOfMilkFeeding { get; set; }
        public double LitersMilkPerDay { get; set; }
    }
}
