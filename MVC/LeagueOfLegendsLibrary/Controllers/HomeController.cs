using LeagueOfLegendsLibrary.Contracts;
using LeagueOfLegendsLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeagueOfLegendsLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILeagueCharacterService s;

        public HomeController(ILogger<HomeController> logger,ILeagueCharacterService s)
        {
            _logger = logger;
            this.s = s;
        }

        public IActionResult Index()
        {
            //LeagueCharacter[] allchars = s.GetQuerry().Take(5).ToArray();
            //Console.WriteLine(allchars.Count());
            //Console.WriteLine(allchars.First().Name);
            //Console.WriteLine(allchars.Last().Name);
            //Console.WriteLine(allchars.ToArray()[2].Name);


            //List<LeagueCharacter> allchars2 = s.GetAllCharacters().Take(5).ToList();
            //Console.WriteLine(allchars2.Count());
            //Console.WriteLine(allchars2.First().Name);
            //Console.WriteLine(allchars2.Last().Name);
            //Console.WriteLine(allchars2.ToArray()[2].Name);
            
            return View();

        }

        public IActionResult Privacy()
        {
            var allCharacters = s.GetAllCharacters();
             
            return View(allCharacters);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}