using BusinessLayer.ViewModels;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessLayer.Utilities;

namespace BlogProject.Controllers.UIControllers
{
    [AllowAnonymous]
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

        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            //List<SelectListItem> categoryvalues = (from x in cm.GetList()
            //                                       select new SelectListItem
            //                                       {
            //                                           Text=x.CategoryName,
            //                                           Value=x.CategoryID.ToString()
            //                                       }).ToList();
            List<Category> categoryvalues = cm.GetList();
            ViewBag.categories = categoryvalues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(BlogCreateViewModel blogViewModel)
        {
            if(ModelState.IsValid)
            {
                string usermail = User.Identity.Name;
                int id = FunctionHelper.GetWriterIdByMail(usermail);
                Blog blog = new Blog
                {
                    BlogTitle = blogViewModel.BlogTitle,
                    BlogContent = blogViewModel.BlogContent,
                    BlogImage = blogViewModel.BlogImage,
                    BlogThumbnailImage = blogViewModel.BlogThumbnailImage,
                    CategoryID = blogViewModel.CategoryID,
                    WriterID = id
                };
                bm.TAdd(blog);
            }
            return RedirectToAction("Dashboard", "WriterPanel");
        }

        public IActionResult BlogDelete(int id)
        {
            if (id.ToString() != null)
            {
                bm.TDelete(bm.GetByID(id));
            }
            return RedirectToAction("Dashboard","WriterPanel");
        }

        public IActionResult BlogEdit(int id)
        {
            Blog blog = bm.GetBlogByID(id)[0];
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            //List<SelectListItem> categoryvalues = (from x in cm.GetList()
            //                                       select new SelectListItem
            //                                       {
            //                                           Text=x.CategoryName,
            //                                           Value=x.CategoryID.ToString()
            //                                       }).ToList();
            List<Category> categoryvalues = cm.GetList();
            ViewBag.categories = categoryvalues;
            BlogCreateViewModel viewModel = new BlogCreateViewModel
            {
                BlogID = blog.BlogID,
                BlogContent = blog.BlogContent,
                BlogImage = blog.BlogImage,
                BlogThumbnailImage = blog.BlogThumbnailImage,
                BlogTitle = blog.BlogTitle,
                CategoryID = blog.CategoryID
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult BlogEdit(BlogCreateViewModel blogViewModel)
        {
            if (ModelState.IsValid)
            {
                Blog blog = bm.GetBlogByID(blogViewModel.BlogID)[0];
                blog.BlogTitle = blogViewModel.BlogTitle;
                blog.BlogContent = blogViewModel.BlogContent;
                blog.BlogImage = blogViewModel.BlogImage;
                blog.BlogThumbnailImage = blogViewModel.BlogThumbnailImage;
                blog.CategoryID = blogViewModel.CategoryID;
                bm.TUpdate(blog);
            }
            return RedirectToAction("Dashboard", "WriterPanel");
        }
    }
}