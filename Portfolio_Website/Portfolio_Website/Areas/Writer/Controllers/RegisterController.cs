using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.Areas.Writer.Models;

namespace Portfolio_Website.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> usermanager)
        {
            _userManager = usermanager;
        }

        [HttpGet]
        public ActionResult RegisterIndex()
        {
            return View();
        }

        [HttpPost]
        
        public async Task <IActionResult> RegisterIndex(UserRegisterViewModel p)
        {
            if (!ModelState.IsValid)
            {
                
                return View();
            }

            WriterUser writerUser = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.UserName,
                  
                };

            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(writerUser, p.Password);

                if (result.Succeeded)
                {
                    //return Redirect("/Writer/Login/LoginIndex");
                    return RedirectToAction("LoginIndex", "Login");

                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }

            return View(p);
        }
    }
}
