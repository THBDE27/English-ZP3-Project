using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        public IActionResult Techniques()
        {
            return View();
        }
    }
}
