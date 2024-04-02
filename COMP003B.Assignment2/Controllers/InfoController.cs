using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        // GET "InfoController/Hobbies"
        public IActionResult Hobbies()
        {
            return View();
        }

        // GET "InfoController/About"
        public IActionResult About()
        {
            return View();
        }
    }
}
