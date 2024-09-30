namespace ReferenceTypesObjectsDemo
{
    internal class Program
    {
        private static void Separator(int dashCount = 20, char symbol = '-')
        {
            Console.WriteLine(new string(symbol, dashCount));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var user1 = new User(10, "Gencho");


            List<User> users = new List<User>();

            users.Add(new User(1, "Valentin"));
            users.Add(new User(3, "Genadi"));
            users.Add(new User(5, "Kamelia"));
            users.Add(new User(6, "Iloslav"));
            users.Add(new User(8, "Preslava"));
            users.Add(new User(10, "Izdislav"));

            User copy = users[3];

            copy.Name = "Krasimir";

            Console.WriteLine(users[3].Name);//Iloslav ili Krasimir?

            Separator();

            User copy2 = new User(users[3].Id, users[3].Name);

            var copy3 = users[3];

            if (copy2 == users[3])
            {
                Console.WriteLine("Равни са обектите");
            }

            if (copy3 == users[3])
            {
                Console.WriteLine("Равни са обектите");
            }

            copy2.Name = "Guliver";
            Console.WriteLine(users[3].Name);//Iloslav ili Krasimir?
            Separator();

            List<User> backup = users;
            backup[2] = null; //Kamelia ostava li ili ne ostava nqkade
        }
    }

    public class User
    {
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public void PrintData()
        {
            Console.WriteLine($"I am {Name}. Id = {Id}");
        }
    }
}