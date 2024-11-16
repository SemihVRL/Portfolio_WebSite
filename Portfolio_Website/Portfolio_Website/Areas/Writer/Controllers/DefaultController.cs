using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Areas.Writer.Controllers
{
    [Area("Writer")]
    //[Authorize]
    public class DefaultController : Controller
    {
        public IActionResult DefaultIndex()
        {
            return View();
        }
    }
}
