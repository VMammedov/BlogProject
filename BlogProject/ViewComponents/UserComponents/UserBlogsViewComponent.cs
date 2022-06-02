using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.UserComponents
{
    public class UserBlogsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            int id = FunctionHelper.GetUserIdByName(User.Identity.Name);
            BlogManager bm = new BlogManager(new EfBlogRepository());
            List<Blog> blogs = bm.GetBlogListByUser(id);
            return View("UserBlogs",blogs);
        }
    }
}
