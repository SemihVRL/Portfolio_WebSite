using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Portfolio_Website.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;
        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IActionResult> DashboardIndex()
        {
            //var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.v = values.Name + " " + values.Surname;
           
            
           //WeatherApi

            string api = "e50dd100359d682ff2fd4037edb779ed";
            string connection ="https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=e50dd100359d682ff2fd4037edb779ed";
            XDocument document=XDocument.Load(connection);
            ViewBag.c = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}

/*
 https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=e50dd100359d682ff2fd4037edb779ed
 
 */