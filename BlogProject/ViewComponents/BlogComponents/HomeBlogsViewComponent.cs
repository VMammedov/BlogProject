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
    public class HomeBlogsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            List<Blog> Blogs = bm.Get3HighRatingBlogList();
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
            return View("HomeBlogs", BlogViewModelList);
        }
    }
}
