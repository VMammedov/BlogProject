using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.BlogComponents
{
    public class LastBlogsOfWriterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            List<Blog> blogs = bm.GetList().TakeLast(3).OrderByDescending(x => x.BlogID).ToList();
            return View("Lastblogsofwriter",blogs);
        }
    }
}
