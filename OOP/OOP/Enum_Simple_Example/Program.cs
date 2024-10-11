namespace Enum_Simple_Example
{
    internal class Program
    {
        static void Main()
        {
            SwitchOnEnum();
            // TryParseNumberDemo();
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


        public static void SwitchOnEnum()
        {
            WeekDay weekDayChosen = Enum.Parse<WeekDay>(Console.ReadLine(), true);




            switch (weekDayChosen)
            {
                case WeekDay.Monday:
                    {
                        Console.WriteLine("Denq ot sedmicata e ponedelnik!!!!!");

                        break;
                    }
                case WeekDay.Tuesday:
                    {

                        break;
                    }
                case WeekDay.Wednesday:
                    {

                        break;
                    }
                case WeekDay.Thursday:
                    {
                        break;
                    }

                case WeekDay.Friday:
                    break;
                case WeekDay.Saturday:
                    break;
                case WeekDay.Sunday:
                    break;


                default: {


                        break;
                    }
            }


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
        public int ManufacturerId { get; set; }// Foreign Key
        public virtual Manufacturer Manufactuer { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CaloriesPer100Grams { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }

    public class Manufacturer
    {
        public virtual List<Candy> Candies { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

}