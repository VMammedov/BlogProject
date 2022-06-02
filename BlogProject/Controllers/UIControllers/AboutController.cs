using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {

        AboutManager am = new AboutManager(new EfAboutRepository());

        public IActionResult Index()
        {
            List<About> values = am.GetList();
            return View(values);
        }
    }
}
