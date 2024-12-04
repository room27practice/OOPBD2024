







using Toolbox;

namespace Extending
{
    internal class Program
    {
        static void Main()
        {
            double d1 = (Console.ReadLine()).ToDouble();

            int[] numbers = { 1, 3, 5, 7, 43, 12, 34, -15 };
            var listN = new List<int>() { 1, -3, 5, 7, 43, 12, 34, -15 };
            HashSet<int> setN = new HashSet<int>(new[] { 1, -3, 5, 7, 43, 12, 34, -15 });
            var result = setN.Where(x => x > 10);
            var test = listN.GetMeValuesSkipingN(2);

            List<int> filtered = listN.MyWhere(x => x > 7);
        }
        public bool FilterOnlyBest(int x)
        {
            if (x > 7)
            {
                return true;
            }
            return false;
        }
    }
}


