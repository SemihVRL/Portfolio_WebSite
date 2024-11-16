using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        AboutManager manager = new AboutManager(new EfAboutDal());
        public IActionResult AboutIndex()
        {
            var values=manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values=manager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            manager.TUpdate(about);
            return RedirectToAction("AboutIndex");
        }

        public IActionResult AboutDelete(int id)
        {
            var values=manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("AboutIndex");
        }


    }
}
