using System.Runtime.CompilerServices;

namespace Toolbox
{
    public static class SwissKnife
    {
        static string ApplicationName = "Candy Shop";
          
        /// <summary>
        /// This is my special method wich takes a collection and returns only fiew elements because it skips n between sequential elements. And makes array!
        /// </summary>
        /// <param name="n">n is number of elements to skip!</param>
        /// <returns></returns>
        public static int[] GetMeValuesSkipingN(this List<int> x, int n = 1)
        {
            var result = new List<int>();
            if (n < 0)
            {
                Console.WriteLine($"Error Brutal Fatal/{ApplicationName}/");
                return null;
            }

            for (int i = 0; i < x.Count(); i = (i + 1) + n)
            {
                result.Add((x[i]));
            }

            return result.ToArray();
        }//6!73sd54.34 -> 67354.34
        /// <summary>
        /// This converts int to double.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double ToDouble(this string x)
        {
            return double.Parse(x);
        }

        public static List<int> MyWhere(this List<int> v, Func<int, bool> predicate)
        {
            var result = new List<int>();
            foreach (var item in v)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine($"Congratulations from {ApplicationName}");
            return result;
        }

        public static List<T> MyWhereGen<T>(this List<T> v, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (T item in v)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine($"Congratulations from {ApplicationName}");
            return result;
        }


    }

}