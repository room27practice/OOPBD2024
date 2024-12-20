﻿using LINQ_DEMO.Models;

namespace LINQ_DEMO
{
    internal class Program
    {
        static void Main()
        {
            List<User> users = new List<User>()
            {
                new User(1, "Aleksandur", "Derivolkov")
                {
                    Pets=new List<Animal>()
                    {
                        new Animal(1,"Nemo",2,AnimalType.Fish),
                        new Animal(2,"Rex",3,AnimalType.Dog),
                        new Animal(3,"Tom",5,AnimalType.Cat),
                    }
                },
                   new User(2, "Djan", "Hasan")
                {
                    Pets=new List<Animal>()
                    {
                        new Animal(4,"Nikiminaj",3,AnimalType.Snake),
                        new Animal(5,"Bobber",3,AnimalType.Hamster),
                    }
                },
                    new User(3, "Viktor", "Botev")
                {
                    Pets=new List<Animal>()
                    {
                        new Animal(6,"Luki",0,AnimalType.Cat),
                        new Animal(7,"Jori",10,AnimalType.Dog),
                    }
                },
                new User(4, "Daniel", "Plamenov")
                {
                    Pets=new List<Animal>()
                    {
                        new Animal(8,"Donatelo",90,AnimalType.Turtle),
                    }
                },
                      new User(5, "Kristian", "Cekov")
                {
                    Pets=new List<Animal>()
                    {
                        new Animal(9,"Keisi",4,AnimalType.Cat),
                        new Animal(10,"Koko",3,AnimalType.Parrot),
                    }
                },
            };



            Console.ReadLine();

            string[] userNames = users.Select(u => u.FName + " " + u.LName).ToArray();

            var userNames2 = users
                .Where(x => x.Pets.Count() > 1)
                .Select(x => $"{x.FName[0]}. {x.LName} Pets Count <{x.Pets.Count()}>")
                .ToArray();

            string[] userNamesWithAnimalNames = users.Select(u => $"{u.FName} {u.LName}: [{string.Join(", ", u.Pets.Select(p => p.Name))}]").ToArray();

            //Aleksandr Derivolkov: [Sharo, Koko]

            User[] usersOwningCat = users.Where(u => u.Pets.Count() % 2 == 1).ToArray();



            var result = users.Select(u =>
            {
                if (u.Pets.Count > 2)
                {
                    return "Tvurde Mnogo domashni liubimci!";
                }
                return $"{u.FName} {u.LName}: [{string.Join(", ", u.Pets.Select(p => p.Name))}]";
            }
           ).ToArray();





        }
    }






}