using DB_DEMO_1.Models;

namespace DB_DEMO_1
{
    internal class Program
    {
        static void Main()
        {

            using (var db = new CandyContext())
            {

                Candy[] allCandies = db.Candies.ToArray();

                Manufacturer[] allManufacturers = db.Manufacturers.ToArray();


                allCandies[0].Price = 99.99m;
                db.SaveChanges();

                #region HowToInsertInDB
                //for (int i = 0; i < 100; i++)
                //{
                //    var n_candy = new Candy("Vafla Borovec", "Mnogo sladka klasicheska vafla s portokalovi korichki, оранжева на цвят.",
                //        401, 48, 0.53m, "https://dayandnightwafers.com/public/thumbs/545x295/products/vafli/borovetz/05-wafer-bor-t-orange-52g_545x295_pad_93e3b5073f.png"
                //                        );
                //    n_candy.Manufacturer = allManufacturers[0];
                //    n_candy.Name = n_candy.Name + i;
                //    db.Candies.Add(n_candy);

                //}

                //db.SaveChanges();
                #endregion



                foreach (var c in allCandies)
                {
                    Console.WriteLine(new string('=', 20));
                    Console.WriteLine($"Candy Name: {c.Name}\nCandy Price:{c.Price:F2}");
                    Console.WriteLine(c.Description);
                }

                Console.ReadLine();
            }

        }
    }
}