using System.Diagnostics;
using System.Globalization;
using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class SocialController : Controller
    {

        //NAOMIE
        List<Swimmer> swimmers = new()
        { 
        new Swimmer("Michael", "Phelps", 30, 6, 1985, "USA", "idk", 23,3,2, false)
        };

        public IActionResult Biographies()
        {
            return View(swimmers);
        }

        public IActionResult Biography(string id)
        {
            int i = 0;
            Swimmer s = swimmers[0];
            while (s.ID != id)
            {
                s = swimmers[i];
                i++;
            }

            return View(s);
        }

        public IActionResult Events()
        {
            return View();
        }
    }
}
