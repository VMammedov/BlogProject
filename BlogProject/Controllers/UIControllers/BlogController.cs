using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            List<Blog> blogs = bm.GetBlogListWithCategory();
            return View(blogs);
        }

        public IActionResult BlogReadAll(int id)
        {
            List<Blog> blogs = bm.GetBlogByID(id);
            ViewBag.id = id;
            return View(blogs);
        }
    }
}
