using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Newtonsoft.Json;

namespace Portfolio_Website.Controllers
{

    public class DefaultController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }

        //[HttpGet]
        //public IActionResult SendMessage()
        //{
        //    return RedirectToAction("Index", "Default");

        //}

        //[HttpPost]
        //public JsonResult SendMessage(Message p)
        //{
        //    manager.TAdd(p);
        //    var values = JsonConvert.SerializeObject(p);
        //    return Json(values);

        //}

        [HttpPost]
        public JsonResult SendMessage(Message p)
        {
            manager.TAdd(p);
            return Json(new { success = true, responseText = "Mesaj başarıyla gönderildi!" });
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            // Kullanıcı doğrudan URL'yi girerse, ana sayfaya yönlendir
            return RedirectToAction("Index", "Default");
        }




    }
}
