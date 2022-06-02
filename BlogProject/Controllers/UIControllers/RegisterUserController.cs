using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        UserManagerBL um = new UserManagerBL(new EfUserRepository());

        [HttpGet]
        public IActionResult Index()
        {
            CountryManager cm = new CountryManager(new EfCountryRepository());
            ViewBag.country = cm.GetList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel user)
        {
            if(ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Email = user.Email,
                    UserName = user.UserName,
                    CountryID = user.CountryID,
                    EmailConfirmed = false,
                    UserFirstName = user.FirstName,
                    UserLastName = user.LastName,
                    UserStatus = false
                };

                var result = await _userManager.CreateAsync(appUser, user.Password);
                
                if(result.Succeeded)
                {
                    Random random = new Random();
                    int number = random.Next(100000, 999999);
                    SecurityCodeViewModel data = new SecurityCodeViewModel
                    {
                        Email = user.Email,
                        Number = number
                    };

                    MimeMessage message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Vusal Mammadli", "xxmixx25@gmail.com"));
                    message.To.Add(new MailboxAddress("VMUBlog_User", user.Email));
                    message.Subject = "Verify Your Account!";
                    StreamReader reader = new StreamReader(@"./wwwroot/EmailTemp.html");
                    string tmp = await reader.ReadToEndAsync();
                    message.Body = new TextPart("html")
                    {
                        Text = tmp.Replace("000000", number.ToString())
                    };

                    using (SmtpClient client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("xxmixx25@gmail.com", "vusalavtos");
                        client.Send(message);
                        client.Disconnect(true);
                        client.Dispose();
                    }
                    TempData["email"] = user.Email;
                    return RedirectToAction("VerifyPage", data);
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(user);
        }

        public IActionResult VerifyPage(SecurityCodeViewModel securityCode)
        {
            return View(securityCode);
        }

        [HttpPost]
        public async Task<IActionResult> ActivateUser(SecurityCodeViewModel securityCode)
        {
            bool stat = true;
            int i = 0;
            List<int> sc = new List<int>() { securityCode.Number1, securityCode.Number2, securityCode.Number3, securityCode.Number4, securityCode.Number5, securityCode.Number6 };

            foreach (var num in securityCode.Number.ToString())
            {
                if (num.ToString() != sc[i].ToString())
                {
                    stat = false;
                    break;
                }
                else
                    i++;
            }

            if (stat)
            {
                int userId = FunctionHelper.GetUserIdByEmail(securityCode.Email);
                AppUser user = await _userManager.FindByIdAsync(userId.ToString());
                user.UserStatus = true;
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("SuccessfullActivation");
            }
            else
            {
                TempData["Error"] = "Invalid Security Code! Please, check code again!";
                return RedirectToAction("VerifyPage", securityCode);
            }
        }

        public IActionResult SuccessfullActivation()
        {
            return View();
        }
    }
}