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

        public IActionResult Biographies()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }
    }
}
