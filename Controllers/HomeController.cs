using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Intro()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files","intro");

            ViewBag.EnText = System.IO.File.ReadAllText(folderPath + "en.txt");
            ViewBag.FrText = System.IO.File.ReadAllText(folderPath + "fr.txt");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
