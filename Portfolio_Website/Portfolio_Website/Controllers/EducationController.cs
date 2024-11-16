using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class EducationController : Controller
    {
        SchoolManager manager = new SchoolManager(new EfSchoolDal());
        public IActionResult EducationIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EducationAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EducationAdd(School p)
        {
            manager.TAdd(p);
            return RedirectToAction("EducationIndex");
        }

        public IActionResult EducationDelete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("EducationIndex");
        }
        [HttpGet]
        public IActionResult EducationUpdate(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EducationUpdate(School school)
        {
            manager.TUpdate(school);
            return RedirectToAction("EducationIndex");
        }
    }
}
