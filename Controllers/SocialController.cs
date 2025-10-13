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
            swimmers.Add(new Swimmer("Michael", "Phelps", 30, 6, 1985, "USA",23,3,2));
            swimmers.Add(new Swimmer("Michael", "Phelps 2", 30, 6, 1985, "USA",23,3,2));

            return View(swimmers);
        }

        public IActionResult Events()
        {
            return View();
        }
    }
}
