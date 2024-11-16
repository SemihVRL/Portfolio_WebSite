using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class SkillController : Controller
    {
        SkillManager manager = new SkillManager(new EfSkillDal());
        public IActionResult SkillIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SkillAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SkillAdd(Skill p)
        {
            SkillValidator validations= new SkillValidator();

            ValidationResult result=validations.Validate(p);
            if (result.IsValid)
            {
                manager.TAdd(p);
                return RedirectToAction("SkillIndex");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }

        public IActionResult SkillDelete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("SkillIndex");
        }

        [HttpGet]
        public IActionResult SkillUpdate(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult SkillUpdate(Skill skill)
        {
            manager.TUpdate(skill);
            return RedirectToAction("SkillIndex");

        }
    }
}

