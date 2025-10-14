using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class SocialController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SocialController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //NAOMIE
        public IActionResult Biographies()
        {
            List<Swimmer> swimmers = new();
            swimmers.Add(new Swimmer("Michael", "Phelps", 30, 6, 1985, "USA", "idk", 23,3,2, false));
            swimmers.Add(new Swimmer("Michael", "Jackson", 29, 8, 1958, "USA","idk", 0,0,0, true));

            return View(swimmers);
        }

        public IActionResult Events()
        {
            return View();
        }
    }
}
