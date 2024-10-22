namespace MethodsAndConstructors
{
    internal class Startup
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            List<int> newNumbers = Hello(10);

            List<int> newNumbers2 = Hello("asdasdasdasd");

            List<int> newNewNumbers3 = Hello();

            var res = Hello("jj");

            DoSomething("Asen"); //Asen 18
            DoSomething("Asen", 10); //Asen 10


            DoSomething(name: "Kuncho", likesPopcorn: false);


            Console.WriteLine("Sumata na chislata e: "+ SumRandomCountOfNumbers(1,4,10,3,4,7,2,-10) );


        }


        static int SumRandomCountOfNumbers(params int[] numbers)
        {
            int sum=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }



        static public List<int> Hello(int num1, int num2)
        {
            return null;
        }

        static public List<int> Hello(int n)
        {
            var result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi chislo");
                result.Add(int.Parse(Console.ReadLine()));
            }
            return result;
        }

        static public List<int> Hello(string word)
        {
            var result = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("Vuvedi chislo");
                result.Add(int.Parse(Console.ReadLine()));
            }
            return result;
        }

        static public List<int> Hello(bool b = true)
        {
            List<string> names = new List<string>();

            return null;
        }


        static void DoSomething(string name, int age = 18, bool likesPopcorn = true)
        {
            Console.WriteLine($"Hello I am {name}. I am {age} years old!");
        }



    }


    public class Hero
    {
        public Hero(int id, string name)
        {
            Id = id;
            Name = name;
        }



        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Tyre
    {
        public Tyre()
        {

        }
        public Tyre(int myProperty)
        {
            MyProperty = myProperty;
        }

        public int MyProperty { get; set; }
    }
}