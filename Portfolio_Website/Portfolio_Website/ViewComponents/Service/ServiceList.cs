using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_Website.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager manager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}
