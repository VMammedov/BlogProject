using BlogProject.Areas.AdminPanel.Models;
using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BlogProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminuserController : Controller
    {
        UserManagerBL um = new UserManagerBL(new EfUserRepository());

        public IActionResult Index(int page=1)
        {
            List<UserAdminListViewModel> users = new List<UserAdminListViewModel>();
            foreach (AppUser item in um.GetList())
            {
                UserAdminListViewModel user = new UserAdminListViewModel
                {
                    UserID = item.Id,
                    UserName = item.UserName,
                    UserMail = item.Email,
                    UserImage = item.UserImage,
                    UserStatus = item.UserStatus
                };
                users.Add(user);
            };
            return View(users.ToPagedList(page, 6));
        }

        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            AppUser user = um.GetByID(id);
            user.UserStatus = false;
            um.TUpdate(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ActivateUser(int id)
        {
            AppUser user = um.GetByID(id);
            user.UserStatus = true;
            um.TUpdate(user);
            return RedirectToAction("Index", "Adminuser");
        }

        public IActionResult UsersByCountry()
        {
            CountryManager cm = new CountryManager(new EfCountryRepository());
            List<UsersChart> usersCharts = new List<UsersChart>();
            List<Country> countries = cm.GetListWithUsers();
            foreach (var item in countries)
            {
                UsersChart userchart = new UsersChart
                {
                      usercountry = item.country,
                      userscountbycountry = item.Users.Count
                };
                usersCharts.Add(userchart);
            }

            return Json(new { usersjson = usersCharts });
        }

        public JsonResult UserDetails(int id)
        {
            AppUser user = um.GetByID(id);
            UserInfoViewModel userInfo = new UserInfoViewModel()
            {
                UserName = user.UserName,
                UserFirstName = user.UserFirstName,
                UserLastName = user.UserLastName,
                UserMail = user.Email,
                UserImage = user.UserImage,
                UserStatus = user.UserStatus,
                Country = user.Country.country,
                BlogsCount = user.Blogs.Count
            };
            string data = JsonConvert.SerializeObject(userInfo);
            return Json(data);
        }

        public IActionResult UserEdit(int id)
        {
            AppUser user = um.GetByID(id);
            UserEditViewModel model = new UserEditViewModel
            {
                UserID = user.Id,
                UserMail = user.Email,
                CountryID = Convert.ToInt32(user.CountryID),
                UserFirstName = user.UserFirstName,
                UserLastName = user.UserLastName,
                UserName = user.UserName,
                UserImagePath = user.UserImage
            };
            CountryManager cm = new CountryManager(new EfCountryRepository());
            ViewBag.country = cm.GetList();
            return View(model);
        }

        [HttpPost]
        public IActionResult UserEdit(UserEditViewModel userEditModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = um.GetByID(userEditModel.UserID);

                user.CountryID = userEditModel.CountryID;
                user.Email = userEditModel.UserMail;
                user.UserFirstName = userEditModel.UserFirstName;
                user.UserLastName = userEditModel.UserLastName;
                user.UserName = userEditModel.UserName;
                if (userEditModel.UserImage != null)
                {
                    user.UserImage = FunctionHelper.UpdateImage(userEditModel.UserImage);
                }
                um.TUpdate(user);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("UserEdit", userEditModel);
            }
        }
    }
}