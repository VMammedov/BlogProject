using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.CommentComponents
{
    public class CommentListByBlogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());
            List<Comment> comments = cm.GetList(id);
            return View("CommentsByBlog",comments);
        }
    }
}
