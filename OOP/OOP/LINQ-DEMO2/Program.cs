using System.Security.Cryptography.X509Certificates;

namespace LINQ_DEMO2
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = input
                .ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', '}', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(x => x.Last())
                .ToArray();

            Console.WriteLine();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}