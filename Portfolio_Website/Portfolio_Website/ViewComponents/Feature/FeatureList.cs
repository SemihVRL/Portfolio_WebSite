using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager manager=new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values=manager.TGetList();
            return View(values);
        }
    }
}
