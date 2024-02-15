using Microsoft.AspNetCore.Mvc;

namespace gettingStarted.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
