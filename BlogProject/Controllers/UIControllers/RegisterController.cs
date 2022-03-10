using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Dto;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            CountryManager cm = new CountryManager(new EfCountryRepository());
            ViewBag.country = cm.GetList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterDto dto)
        {
            if (ModelState.IsValid)
            {
                wm.WriterAdd(dto);
            }
            return RedirectToAction("Index", "Blog");
        }
    }
}
