using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class FeatureController : Controller
    {
        FeatureManager manager = new FeatureManager(new EfFeatureDal());
        public IActionResult FeatureIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }

        public IActionResult FeatureDelete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("FeatureIndex");
        }
        [HttpGet]
        public IActionResult FeatureUpdate(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult FeatureUpdate(Feature feature)
        {
            manager.TUpdate(feature);
            return RedirectToAction("FeatureIndex");
        }

    }
}
