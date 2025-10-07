using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;

namespace English_ZP3_Project.Controllers
{
    public class TechController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TechController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Technology()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "technologies");

            string[] fileNames = Directory.GetFiles(folderPath, "*.txt");
            List<Technology> files = new();

            foreach (string fileName in fileNames)
            {
                files.Add(new Technology(fileName));
            }

            return View(files);
        }

        public IActionResult Techniques()
        {
            return View();
        }
    }
}
