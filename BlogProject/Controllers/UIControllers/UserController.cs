using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ValidationRules;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        UserManagerBL um = new UserManagerBL(new EfUserRepository());

        public async Task<IActionResult> EditUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel 
            {
                UserMail = user.Email,
                UserFirstName = user.UserFirstName,
                UserLastName = user.UserLastName,
                UserName = user.UserName,
                UserImagePath = user.UserImage==null? "empty_user.png" : user.UserImage
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserEditViewModel userEditModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                user.Email = userEditModel.UserMail;
                user.UserFirstName = userEditModel.UserFirstName;
                user.UserLastName = userEditModel.UserLastName;
                user.UserName = userEditModel.UserName;
                if (userEditModel.UserImage!=null)
                {
                    user.UserImage = FunctionHelper.UpdateImage(userEditModel.UserImage);
                }

                await _userManager.UpdateAsync(user);
                return RedirectToAction("Dashboard", "UserPanel");
            }
            else
            {
                return RedirectToAction("Dashboard", userEditModel);
            }
        }

        public IActionResult DeleteMyUserAccount()
        {
            int id = FunctionHelper.GetUserIdByName(User.Identity.Name);
            if (id.ToString() != null)
            {
                um.TDelete(um.GetByID(id));
            }
            return RedirectToAction("Index", "Login");
        }

    }
}