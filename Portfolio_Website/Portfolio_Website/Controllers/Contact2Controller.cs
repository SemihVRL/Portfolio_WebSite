using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    public class Contact2Controller : Controller
    {
        ContactManager manager = new ContactManager(new EfContactDal());
        public IActionResult Contact2Index()
        {
            var values = manager.TGetList();
            return View(values);
        }
        public IActionResult Contact2Delete(int id)
        {
            var values = manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("Contact2Index");
        }

        [HttpGet]
        public IActionResult Contact2Update(int id)
        {
            var values = manager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Contact2Update(Contact contact)
        {
            manager.TUpdate(contact);
            return RedirectToAction("Contact2Index");
        }
    }
}
