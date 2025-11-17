using English_ZP3_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace English_ZP3_Project.Controllers
{
    public class BiologyController : Controller
    {

        //NAOMIE
        List<List<Swimmer>> swimmers = new()
        {
            new() 
            {
        new Swimmer("Michael", "Phelps", 30, 6, 1985, "USA", "butterfly and individual medley", 23,3,2, false),
        new Swimmer("Gretchen", "Walsh", 29, 1, 2003, "USA", "freestyle and butterfly", 2, 2, 0, false)
            },
            new() 
            {
        new Swimmer("Michael", "Phelps", 30, 6, 1985, "USA", "butterfly and individual medley", 23,3,2, false),
        new Swimmer("Gretchen", "Walsh", 29, 1, 2003, "USA", "freestyle and butterfly", 2, 2, 0, false)
            }
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
            Swimmer s;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < swimmers[i].Count; j++)
                {
                    s = swimmers[i][j];
                    if (s.ID == id)
                    {
                        return View(s);
                    }
                    
                }
               
            }
            return View(swimmers[0][0]);


        }

    }
}
