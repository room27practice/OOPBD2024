using System.Globalization;

namespace DateTimeDemo
{
    internal class Program
    {
        static void Main()
        {
            string dateTest = "12.03.2024-16:54";
            string dateTest2 = "03.12.2024 4:54PM";
            string dateTest3 = "4:54PM 2024_03_12";
            var date1 = DateTime.ParseExact(dateTest, "dd.MM.yyyy-HH:mm", CultureInfo.InvariantCulture);
            // " Chasa e : 16:54. Denq e 12ti. Meseca e march kato godinata e 24"
            Console.WriteLine($"Chasa e : {date1.Hour}:54. Denq e 12ti. Meseca e march kato godinata e 24");
            Console.WriteLine(date1.ToString("HH:mm [dd.MMMM.yy]"));
            DateTime dt1 = DateTime.UtcNow;
            dt1.AddHours(-2);
            Console.WriteLine(dt1.Year);
        }
    }
}