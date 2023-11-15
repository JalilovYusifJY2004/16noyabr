using Microsoft.AspNetCore.Mvc;

namespace _16noyabr.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
