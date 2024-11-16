using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents.School
{
    public class SchoolList:ViewComponent
    {
        SchoolManager manager = new SchoolManager(new EfSchoolDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}
