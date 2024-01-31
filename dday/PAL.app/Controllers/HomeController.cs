using Microsoft.AspNetCore.Mvc;

namespace PAL.app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
