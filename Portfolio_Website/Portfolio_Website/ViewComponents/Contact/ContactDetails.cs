using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Portfolio_Website.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager manager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }

       
    }
}
