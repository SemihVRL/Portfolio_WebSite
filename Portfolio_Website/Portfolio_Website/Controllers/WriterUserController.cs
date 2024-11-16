using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Portfolio_Website.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager manager = new WriterUserManager(new EfWriterUserDal());

        public IActionResult WriterUserIndex()
        {
           return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(manager.TGetList());
            //Serializeobject listemek için kullanılır
            return Json(values);
        }

        
    }
}
