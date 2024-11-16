using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Portfolio_Website.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager manager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}
