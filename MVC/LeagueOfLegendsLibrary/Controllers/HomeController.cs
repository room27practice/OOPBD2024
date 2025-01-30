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
            return View();
        }

        public IActionResult Privacy()
        {
            var allCharacters = s.GetAllCharacters();
                       
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}