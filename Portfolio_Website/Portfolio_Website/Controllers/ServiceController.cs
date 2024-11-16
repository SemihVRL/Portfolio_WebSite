using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Authorize]
    public class ServiceController : Controller
    {
        ServiceManager manager = new ServiceManager(new EfServiceDal());
        public IActionResult ServiceIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ServiceAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ServiceAdd(Service p)
        {
            manager.TAdd(p);
            return RedirectToAction("ServiceIndex");
        }

        public IActionResult ServiceDelete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("ServiceIndex");
        }

        [HttpGet]
        public IActionResult ServiceUpdate(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ServiceUpdate(Service service)
        {
            manager.TUpdate(service);
            return RedirectToAction("ServiceIndex");
        }

    }
}
