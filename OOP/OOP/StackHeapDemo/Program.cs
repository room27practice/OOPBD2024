using System.Globalization;

namespace StackHeapDemo
{
    internal class Program
    {
        private static void Separator(int dashCount, char symbol = '-')
        {
            Console.WriteLine(new string(symbol, dashCount));
        }

        static void Main()
        {
            #region ValueTypesDemo
            int a = 15; //string, char, int, double , bool 
            int b = a;

            Console.WriteLine(a); //15            

            Console.WriteLine(b); //15

            Separator(30);

            b = 20;

            Console.WriteLine(a); //15


            Console.WriteLine(b); //20
            Separator(30);
            #endregion
            
          
            Separator(30);

            int[] numbers = { 1, 5, 10, 15,10,-3,2 }; // 1-5-10-15

            //Вариант А
            int[] copy = numbers;

            //Вариант B
            int[] copy2 = new int[numbers.Length];

            for (int i = 0; i < copy2.Length; i++)
            {
                copy2[i] = numbers[i];
            }

            int[] copy3 = numbers.ToArray();

            Console.WriteLine(string.Join(' ', numbers));
            Separator(30);
            Console.WriteLine(string.Join(' ', copy));
            Separator(30);

            copy[1] = 5000;
            numbers[0] = 1234;

            Console.WriteLine(string.Join(' ', numbers));// 1-5-10-15
            Separator(30);
            Console.WriteLine(string.Join(' ', copy));// 1-5000-10-15
            Separator(30);

            copy2[0] = -1000;
            copy2[copy2.Length-1] = -1000;

            Console.WriteLine(string.Join(' ', numbers));//
            Separator(30);
            Console.WriteLine(string.Join(' ', copy2));// 
            Separator(30);

        }
    }
}