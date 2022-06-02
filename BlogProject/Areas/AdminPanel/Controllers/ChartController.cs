using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
