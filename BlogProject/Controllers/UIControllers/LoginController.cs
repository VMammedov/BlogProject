using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginDto login)
        {
            try
            {
                string a = User.Identity.Name;
                AppUser user = await _userManager.FindByNameAsync(login.Name);
                bool emailConfirmation = await _userManager.IsEmailConfirmedAsync(user);
                if (ModelState.IsValid && emailConfirmation && user.UserStatus)
                {
                    var result = await _signInManager.PasswordSignInAsync(login.Name, login.Password, false, true);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "Blog");
                    // If Email not confirmed, give a action for it
                    else
                        return View();
                }
                return View();
            }
            catch (Exception)
            {
                TempData["LoginError"] = "Username or Password is not valid!";
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}





//[AllowAnonymous]
//[HttpPost]
//public async Task<IActionResult> Index(Writer p)
//{
//    Context c = new Context();
//    var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
//    if (datavalue != null)
//    {
//        List<Claim> claims = new List<Claim>
//        {
//            new Claim(ClaimTypes.Name,p.WriterMail)
//        };
//        var useridentity = new ClaimsIdentity(claims, "a");
//        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
//        await HttpContext.SignInAsync(principal);
//        return RedirectToAction("Dashboard", "WriterPanel");
//    }
//    else
//        return RedirectToAction("Index");
//}