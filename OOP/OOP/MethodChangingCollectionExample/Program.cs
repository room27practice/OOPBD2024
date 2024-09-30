namespace MethodChangingCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("1. Georgi");
            names.Add("2. Galin");
            names.Add("3. Gancho");
            names.Add("4. Genka");
            PrintNames(names);

            Console.WriteLine(string.Join(' ', names));
        }


        private static void PrintNames(List<string> names)
        {
            //   List<string> temp = names.ToList();

            int rotations = names.Count();
            for (int i = 0; i < rotations; i++)
            {
                Console.WriteLine(names[0]);
                if (i % 2 == 0)
                {
                    names.RemoveAt(0);
                }
            }
        }
    }
}