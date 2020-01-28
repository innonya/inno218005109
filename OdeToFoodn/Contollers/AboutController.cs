using Microsoft.AspNetCore.Mvc;

namespace OdeToFoodn.Contollers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}