using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        PortfolioManager manager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult ProjectIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ProjectAdd()
        {
            return View();

        }
        [HttpPost]
        public IActionResult ProjectAdd(Portfolio p)
        {
            manager.TAdd(p);
            return RedirectToAction("ProjectIndex");

        }

        public IActionResult ProjectDelete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("ProjectIndex");
        }

        [HttpGet]
        public IActionResult ProjectUpdate(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult ProjectUpdate(Portfolio p)
        {
            manager.TUpdate(p);
            return RedirectToAction("ProjectIndex");

        }
    }
}
