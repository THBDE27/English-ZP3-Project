using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace English_ZP3_Project.Controllers
{
    public class BiologyController : Controller
    {

        //NAOMIE
        List<Swimmer> swimmers = new()
        {
        new Swimmer("Michael", "Phelps", 30, 6, 1985, "USA", "butterly and individual medley", 23,3,2, false),
        new Swimmer("Gretchen", "Walsh", 29, 1, 2003, "USA", "freestyle and butterfly", 2, 2, 0, false)
        };

        public IActionResult Biographies()
        {
            return View(swimmers);
        }
        public IActionResult PhysicalExam()
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

    }
}
