using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    public class UserPanelController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public UserPanelController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        UserManagerBL um = new UserManagerBL(new EfUserRepository());

        public async Task<IActionResult> Dashboard()
        {
            List<int> values = new List<int>();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View();
        }
    }
}
