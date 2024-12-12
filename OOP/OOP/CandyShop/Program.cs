using CandyShop.Models;

namespace CandyShop
{
    internal class Program
    {
        static void Main()
        {
            Candy lp1 = new Lolipop("ChupaChups", 400, Color.Red);
            Cake c1 = new Cake("Shokoladena", 600, 8, false);
            Candy c2 = new Cake("Smetanova", 500, 6, true);                  
           
            List<Candy> products = new List<Candy>();
            products.Add(lp1);
            products.Add(c1);
            products.Add(c2);
            Cake result = lp1 as Cake;
            if (result != null)
            {
            }
            Cake result2 = (Cake)c2;
        }
    }
}