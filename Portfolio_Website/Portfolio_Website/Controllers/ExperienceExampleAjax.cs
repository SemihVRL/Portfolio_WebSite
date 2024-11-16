using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Portfolio_Website.Controllers
{
    public class ExperienceExampleAjax : Controller
    {
        ExperienceManager manager = new ExperienceManager(new EfExperienceDal());
        public IActionResult ExperienceExampleAjaxIndex()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(manager.TGetList());
           
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            manager.TAdd(p);
            var add1 = JsonConvert.SerializeObject(p);
            return Json(add1);
        }

        public IActionResult IdFind(int ExperID)
        {
            var v= manager.TGetByID(ExperID);
            var values=JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteExper(int id)
        {
            var v=manager.TGetByID(id);
            manager.TDelete(v);
            //silme işlemi olduğu için json formatına gerek yok
            return Ok();
        }
    }
}
