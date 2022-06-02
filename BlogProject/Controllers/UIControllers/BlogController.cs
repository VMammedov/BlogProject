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
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            List<Blog> Blogs = bm.GetBlogListWithEntities();
            List<BlogListViewModel> BlogViewModelList = new List<BlogListViewModel>();
            foreach (Blog item in Blogs)
            {
                BlogListViewModel blog = new BlogListViewModel()
                {
                    BlogID = item.BlogID,
                    BlogTitle = item.BlogTitle,
                    BlogContent = item.BlogContent,
                    BlogCreateDate = item.BlogCreateDate,
                    BlogRating = item.BlogRating,
                    BlogThumbnailImage = item.BlogThumbnailImage,
                    Category = item.Category.CategoryName,
                    CommentsCount = item.Comments.Count,
                    UserName = item.User.UserName,
                    UserId = item.User.Id
                };
                BlogViewModelList.Add(blog);
            }
            return View(BlogViewModelList);
        }

        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            Blog blog = bm.GetByID(id);
            return View(blog);
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
                int id = FunctionHelper.GetUserIdByName(User.Identity.Name);
                Blog blog = new Blog
                {
                    BlogTitle = blogViewModel.BlogTitle,
                    BlogContent = blogViewModel.BlogContent,
                    CategoryID = blogViewModel.CategoryID,
                    UserId = id
                };
                if (blogViewModel.BlogImage != null)
                    blog.BlogImage = FunctionHelper.AddBlogImage(blogViewModel.BlogImage);
                if (blogViewModel.BlogThumbnailImage != null)
                    blog.BlogThumbnailImage = FunctionHelper.AddBlogImage(blogViewModel.BlogThumbnailImage);
                bm.TAdd(blog);
            }
            return RedirectToAction("Dashboard", "UserPanel");
        }

        public IActionResult BlogDelete(int id)
        {
            if (id.ToString() != null)
            {
                bm.TDelete(bm.GetByID(id));
            }
            return RedirectToAction("Dashboard", "UserPanel");
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
                BlogImagePath = blog.BlogImage,
                BlogThumbnailImagePath = blog.BlogThumbnailImage,
                BlogTitle = blog.BlogTitle,
                CategoryID = (int)blog.CategoryID
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult BlogEdit(BlogCreateViewModel blogViewModel)
        {
            if (ModelState.IsValid)
            {
                Blog blog = bm.GetBlogByID(blogViewModel.BlogID).FirstOrDefault();
                blog.BlogTitle = blogViewModel.BlogTitle;
                blog.BlogContent = blogViewModel.BlogContent;
                blog.CategoryID = blogViewModel.CategoryID;
                if (blogViewModel.BlogImage != null)
                    blog.BlogImage = FunctionHelper.AddBlogImage(blogViewModel.BlogImage);
                if (blogViewModel.BlogThumbnailImage != null)
                    blog.BlogThumbnailImage = FunctionHelper.AddBlogImage(blogViewModel.BlogThumbnailImage);
                bm.TUpdate(blog);
            }
            return RedirectToAction("Dashboard", "UserPanel");
        }
    }
}