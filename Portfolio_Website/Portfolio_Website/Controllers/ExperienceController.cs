using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class ExperienceController : Controller
    {
        ExperienceManager manager = new ExperienceManager(new EfExperienceDal());
        public IActionResult ExperienceIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ExperienceAdd(Experience p)
        {
            manager.TAdd(p);
            return RedirectToAction("ExperienceIndex");
        }
        public IActionResult ExperienceDelete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("ExperienceIndex");
        }
        [HttpGet]
        public IActionResult ExperienceUpdate(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ExperienceUpdate(Experience experience)
        {
            manager.TUpdate(experience);
            return RedirectToAction("ExperienceIndex");
        }
    }
}
