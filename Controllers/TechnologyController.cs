using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using English_ZP3_Project.Models.Technologies;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;

namespace English_ZP3_Project.Controllers
{
    public class TechnologyController : Controller
    {
        private readonly IWebHostEnvironment Env;

        public TechnologyController(IWebHostEnvironment env)
        {
            Env = env;
        }

        public IActionResult Technology(string id)
        {
            return View(new Technology(id, Env));
        }




        public IActionResult Reports()
        {
            string folderPath = Path.Combine(Env.WebRootPath, "files", "reports");

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
