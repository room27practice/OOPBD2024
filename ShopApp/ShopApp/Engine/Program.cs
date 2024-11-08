using Data.Models;

namespace Engine
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");



            using (var db=new ShopDbContext())
            {
                List<Purpose> purposesToAdd= new List<Purpose>();
               //TODO Add purposes
                
                List<Person> peopleToAdd = new List<Person>();
                //TODO Add Shop

                db.AddRange(purposesToAdd);
                db.AddRange(peopleToAdd);
                db.SaveChanges();
            }
        }
    }
}