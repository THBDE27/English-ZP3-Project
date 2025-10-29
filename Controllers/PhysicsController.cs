using English_ZP3_Project.Helpers;
using Microsoft.AspNetCore.Mvc;
using static NuGet.Packaging.PackagingConstants;

namespace English_ZP3_Project.Controllers
{
    public class PhysicsController : Controller
    {
        private readonly FileHelper _fileHelper;

        public PhysicsController(FileHelper fileHelper)
        {
            _fileHelper = fileHelper;
        }

        public IActionResult Techniques()
        { 
            return View(_fileHelper.GetVideoSources("videos"));
        }
    }
}
