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

        public IActionResult Index()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");

            // Read both files
            string enFile = Path.Combine(folderPath, "introen.txt");
            string frFile = Path.Combine(folderPath, "introfr.txt");

            string enText = System.IO.File.ReadAllText(enFile);
            string frText = System.IO.File.ReadAllText(frFile);

            // Pass to ViewBag
            ViewBag.EnText = enText;
            ViewBag.FrText = frText;

            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
