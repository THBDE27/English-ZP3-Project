using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class HealthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HealthController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PhysicalExam()
        {
            return View();
        }

        public IActionResult Benefits()
        {
            return View();
        }

        public IActionResult WorkoutPlan()
        {
            return View();
        }
    }
}
