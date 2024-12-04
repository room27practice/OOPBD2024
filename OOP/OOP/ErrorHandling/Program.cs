namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Testing();
                Console.WriteLine("Congratulations successfull Completion");
            }
            catch (MySpecialException ex)
            {
                Console.WriteLine("Abe ne stana rabotata "+ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }

        }

        private static void Testing()
        {
            int[] arr = new[] { 10, -20 };

            string n = Console.ReadLine();
            if (n.Any(d => !char.IsDigit(d)))
            {
                throw new MySpecialException("Greshni neshta podavash!!! ne moje bukvi");
            }
            int choise = int.Parse(n);
            Console.WriteLine(arr[choise]);
        }
    }
}