using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager manager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values=manager.TGetList();
            return View(values);
        }
    }
}
