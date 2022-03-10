using BlogProject.Areas.AdminPanel.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminWriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WritersByCountry()
        {
            CountryManager cm = new CountryManager(new EfCountryRepository());
            List<WritersChart> writersCharts = new List<WritersChart>();
            List<Country> countries = cm.GetListWithWriters();
            foreach (var item in countries)
            {
                WritersChart writerchart = new WritersChart
                {
                      writercountry = item.country,
                      writerscountbycountry = item.Writers.Count
                };
                writersCharts.Add(writerchart);
            }

            return Json(new { writersjson = writersCharts });
        }
    }
}
