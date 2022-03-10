using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.WriterComponents
{
    public class WriterBlogsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string usermail = User.Identity.Name;
            int id = FunctionHelper.GetWriterIdByMail(usermail);
            BlogManager bm = new BlogManager(new EfBlogRepository());
            List<Blog> blogs = bm.GetBlogListByWriter(id);
            return View("WriterBlogs",blogs);
        }
    }
}
