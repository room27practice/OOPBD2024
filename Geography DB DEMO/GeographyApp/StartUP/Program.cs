using Microsoft.EntityFrameworkCore;
using StartUP.DataModels;

namespace StartUP
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Geography Mountains Data");

            Mountain[] downloadedMountains = null;

            using (GeographyContext db = new GeographyContext())
            {
                downloadedMountains = db.Mountains.Include(x => x.Peaks).ToArray();
            }

            foreach (var mountain in downloadedMountains)
            {
                Console.WriteLine($"<-------{mountain.MountainRange}------->");
                if (mountain.Peaks.Count() > 0)
                {
                    foreach (var p in mountain.Peaks)
                    {
                        Console.WriteLine($"- {p.PeakName} [Altutude - {p.Elevation} m.]");
                    }
                }
                else
                {
                    Console.WriteLine("No peaks sorry :( ");
                }
                Console.WriteLine(new string('=', 20));               
            }


            //Mountain newMountain = new Mountain() { MountainRange = "PGMETT Mountain" };            
            //newMountain.Peaks.Add(new Peak() { Elevation = 3300, PeakName = "Programirane", });
            //newMountain.Peaks.Add(new Peak() { Elevation = 2200, PeakName = "KTT", });

            //using (GeographyContext db = new GeographyContext())
            //{
            //    db.Mountains.Add(newMountain);
            //    db.SaveChanges();
            //}


        }
    }
}