namespace Enum_Simple_Example
{
    internal class Program
    {
        static void Main()
        {
            TryParseNumberDemo();
           // EnumDemo();
        }

        private static void TryParseNumberDemo()
        {
            double result = 0;
            string number = Console.ReadLine();
            while (!double.TryParse(number, out result))
            {

                Console.WriteLine("Ne uspq probvai pak");
                number = Console.ReadLine();
            }

            Console.WriteLine($"Uspq da vuvedesh chislo {result}");

        }
        private static void EnumDemo()
        {
            string[] data = Enum.GetNames<WeekDay>();

            Console.WriteLine("Choose one day of week:\n Options:");

            foreach (var day in Enum.GetNames<WeekDay>().Reverse())
            {
                Console.WriteLine(day);
            }

            string input = Console.ReadLine();//Monday | monday | MONDAY

            WeekDay dayChosen = Enum.Parse<WeekDay>(input, true);

            Console.WriteLine($"{dayChosen.ToString()} - {(int)dayChosen}");

            WeekDay daySelectedByInt = (WeekDay)3;
            Console.WriteLine($"{daySelectedByInt.ToString()} - {(int)daySelectedByInt}");
        }

    }

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }



    public class Candy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CaloriesPer100Grams { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}