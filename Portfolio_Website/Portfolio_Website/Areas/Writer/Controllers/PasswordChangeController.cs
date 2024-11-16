using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.Areas.Writer.Models;
using System.Runtime.CompilerServices;

namespace Portfolio_Website.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        private readonly SignInManager<WriterUser> _signInManager;
        public PasswordChangeController(UserManager<WriterUser> usermanager, SignInManager<WriterUser> signInManager)
        {
            _userManager = usermanager;
            _signInManager = signInManager;
        }

     

        [HttpGet]
        public IActionResult PasswordIndex()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> PasswordIndex(UserPasswordViewModel p)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("LoginIndex", "Login");
            }

            var result = await _userManager.ChangePasswordAsync(user, p.CurrentPassword, p.NewPassword);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
           
            await _signInManager.RefreshSignInAsync(user);


            return View();
        }


    }
}
