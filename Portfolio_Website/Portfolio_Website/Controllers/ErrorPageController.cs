using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorIndex()
        {
            return View();
        }
    }
}
