using Microsoft.AspNetCore.Mvc;
using Web_final.Models;

namespace Web_final.Controller
{
    public class HomeController : Controller
    {
        private characters context;
        public HomeController(characters ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
