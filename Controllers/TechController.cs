using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;

namespace English_ZP3_Project.Controllers
{
    public class TechController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public TechController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Technology()
        {
            string folderPath = Path.Combine(_env.WebRootPath, "files", "technologies");

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

        public IActionResult Reports()
        {
            string folderPath = Path.Combine(_env.WebRootPath, "files", "reports");

            string[] pdfPaths = Directory.GetFiles(folderPath, "*.pdf");


            List<ReportFile> files = new();
            foreach (string pdfPath in pdfPaths)
            {
                files.Add(new(pdfPath));
            }

            return View(files);
        }
    }
}
