namespace Enumerations
{
    internal class Program
    {
        static void Main()
        {
            // List<User> users = new List<User>()

            //{
            //new User(){Id=1,Name="Asen",Town="Shumen",Address="Bialata prust",Phone="0887774343"},
            //new User(){Id=2,Name="Ivan",Town="SHUMEN",Address="Bialata prust",Phone="0887774343"},
            //new User(){Id=3,Name="Vanessa",Town="shumen",Address="Bialata prust",Phone="0887774343"},
            //new User(){Id=1,Name="Georgi",Town="ShUmEn",Address="Bialata prust",Phone="0887774343"},
            //new User(){Id=1,Name="Samuel",Town="Shummen",Address="Bialata prust",Phone="0887774343" },
            //new User(){Id=1,Name="Alisia",Town="Шумен",Address="Bialata prust",Phone="0887774343" },
            //           };

            //foreach (var u in users)
            //{
            //    if (u.Town == "Shumen")
            //    {
            //        Console.WriteLine($"User is {u.Name}");
            //    }

            //}

            User u1 = new User() { Id = 2, Name = "Ivan", Town = Town.Kavarna, Address = "Bialata prust" };

            User u2 = new User(19, "Purvoslav", Town.Plovdiv, "0881234567", "Stara planina 82");

            User u3 = new User(8, "Kuncho");

            Console.WriteLine("Hello, World!");

        }
    }

    public class User
    {
        public User()
        { }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public User(int id, string name, Town town, string phone, string address)
        {
            if (phone.Length == 10)
            {
                Phone = phone;
            }
            else
            {
                Console.WriteLine("Error fatal total brutal phone was incorrect");
                Phone = "1111111111";
            }
            Address = address;
            Town = town;
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Town Town { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public enum Town
    {
        Undefined = 0,
        Shumen = 12,
        Plovdiv = 10,
        Kavarna = 11,
    }

}