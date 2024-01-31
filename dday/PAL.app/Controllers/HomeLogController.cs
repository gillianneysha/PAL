using Microsoft.AspNetCore.Mvc;

namespace PAL.app.Controllers
{
    public class HomeLogController : Controller
    {
        public IActionResult IndexStart()
        {
            return View();
        }
    }
}
