using Microsoft.AspNetCore.Mvc;

namespace PalmyraTV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Watch()
        {
            return View();
        }
    }
}