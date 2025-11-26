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
new Swimmer("Gretchen", "Walsh", 29, 1, 2003, "USA", "freestyle and butterfly", 2, 2, 0, false),
new Swimmer("Katie", "Ledecky", 7, 3, 1997, "USA", "freestyle", 9, 4, 1, false),
new Swimmer("Ian", "Thorpe", 13, 10, 1982, "Australia", "freestyle", 3, 2, 0, false),
new Swimmer("Caeleb", "Dressel", 16, 8, 1996, "USA", "freestyle and butterfly", 8, 1, 0, false)


            },
            new() 
            {
       new Swimmer("Léon", "Marchand", 17, 3, 2002, "USA", "individual medley and butterfly", 4, 0, 1, false),
new Swimmer("Summer", "McIntosh", 18, 8, 2006, "Canada", "freestyle and butterfly", 3, 1, 0, false),
new Swimmer("Sarah", "Sjöeström", 17, 8, 1993, "Sweden", "freestyle and butterfly", 3, 2, 1, false),
new Swimmer("Kaylee", "McKeown", 12, 7, 2001, "Australia", "backstroke", 5, 1, 3, false) }
        };

        public IActionResult Biographies()
        {
            return View(swimmers);
        }
        public IActionResult PhysicalExam()
        {
            return View(swimmers);
        }

        public IActionResult FamousAnatomies(string id)
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
