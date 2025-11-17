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

        public IActionResult Glossary()
        {

            return View(Word.GetGlossary());
        }

        public IActionResult Conclusion()
        {

            return View();
        }


} 
}
