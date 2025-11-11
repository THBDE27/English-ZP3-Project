using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class ConclusionController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public ConclusionController(IWebHostEnvironment env)
        {
            _env = env;
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

        public IActionResult Glossary()
        {

            return View(Word.GetGlossary());
        }


  



} 
}
