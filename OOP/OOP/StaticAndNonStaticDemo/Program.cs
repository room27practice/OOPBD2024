namespace StaticAndNonStaticDemo
{
    internal class Program
    {
        private static string name = "Kuncho";
        private static double mulptipicatorFactor = 15.43;

        static void Main()
        {
            var u1 = new User {Id=1, FirstName = "Sasho", LastName = "Roman", Gender = true, Email = "sashko@abv.bg" };
            var u2 = new User {Id=12, FirstName = "Ivan", LastName = "Goshkov", Gender = true, Email = "vangok@yahoo.mail" };
            var u3 = new User {Id=30, FirstName = "kirilka", LastName = "Mihneva", Gender = false, Email = "kimir@gmail.com" };
            var u4 = new User {Id=27, FirstName = "Mecho", LastName = "Bass", Gender = true, Email = "mecho@abv.bg" };
            var u5 = new User {Id=2, FirstName = "Toni", LastName = "Storaro", Gender = true, Email = "t.storaro@mail.ru" };

            u1.PresentYourself();
            u2.PresentYourself();
            u3.PresentYourself();
            u4.PresentYourself();
            u5.PresentYourself();
            
            User.RepresentFormat = "Kazvam se {0}. \nObicham shopska salata. \nImam Id={1}. Opredelqm se kato {2}. \n. Moq imeil e {3}";

            u4.PresentYourself();
            u5.PresentYourself();

          
            Console.WriteLine(Calculator.Sum(10.3,4.8));
          
            Console.WriteLine(Calculator.Name);
            
            Calculator.Name = "Umopomrachitelen smetach";
            Console.WriteLine(Calculator.Name);
            Console.WriteLine(name + 15*mulptipicatorFactor);           
        }
    }

    public class User
    {
        public static string RepresentFormat = "I am {0}.\nI have Id {1}. \nMy Gender is {2}. \nWrite me on {3}";        
        public int Id { get; set; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; } //true = male | false = female
        public string Email { get; set; }
       
        public void PresentYourself()
        {
            string result = string.Format(RepresentFormat, FirstName.Substring(0,3) + ". " + LastName, Id, (Gender ? "male" : "female"), Email);
           
            Console.WriteLine(result);
            Console.WriteLine(new string('-',30));
        }
    }

    public static class Calculator
    {

        public static string Name { get; set; } = "Mislitelq";      
        
        public static double Sum(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public static double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public static double Parsify(string number)
        {
            return double.Parse(number);
        }


    }

}