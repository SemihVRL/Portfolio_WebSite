using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.Areas.Writer.Models;

namespace Portfolio_Website.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
    {
        
        private readonly SignInManager<WriterUser> _signInManager;
        public LoginController(SignInManager<WriterUser> signInManager)
        {
           _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LoginIndex()
        {
            return View();
        }


        [HttpPost]
        public async Task< IActionResult> LoginIndex(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("FeatureIndex", "Feature");
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Hatalı Kullanıcı Adı veya Şifre");
                }
            }


            return View(p);

            //if (!ModelState.IsValid)
            //{

            //    return View();
            //}
            //var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);
            //if (result.Succeeded)
            //{
            //    return RedirectToAction("Index", "Default");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Şifre");
            //}
            //return View(p);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LoginIndex","Login");
        }
    }
}
