using BusinessLayer.Concrete;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.BlogComponents
{
    public class RecentBlogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            Blog Blog = bm.GetList().LastOrDefault();
            BlogListViewModel blog = new BlogListViewModel()
            {
                BlogID = Blog.BlogID,
                BlogTitle = Blog.BlogTitle,
                BlogThumbnailImage = Blog.BlogThumbnailImage,
                BlogCreateDate = Blog.BlogCreateDate
            };
            return View("RecentBlog", blog);
        }
    }
}
