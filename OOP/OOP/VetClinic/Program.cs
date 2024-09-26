

using System.Text;

namespace VetClinic
{
    internal class Program
    {
        static void Main()
        {
            VetClinic vetC1 = new VetClinic();
            Console.WriteLine($"Tax is {vetC1.TaxRevenue()}");
            Console.WriteLine($"Tax is {vetC1.Tax}");
            Console.WriteLine($"Tax is {vetC1.NegativeTax}");           
            vetC1.HealedAnimals.Add(new Animal());            
          
            //Primeri za namespaces
            
            Animal an1 = new Animal();
           
            Alternative.Animal an2 = new Alternative.Animal();
            

    



        }
    }

}


namespace VetClinic
{
}
