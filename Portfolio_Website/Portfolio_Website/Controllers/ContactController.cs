using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    //[Authorize]
    public class ContactController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageDal());
        public IActionResult ContactIndex()
        {
            var values = manager.TGetList();
            return View(values);
        }

        public IActionResult ContactDelete(int id)
        {
            var values =manager.TGetByID(id);
            manager.TDelete(values);
            return RedirectToAction("ContactIndex");
        }
    }
}
