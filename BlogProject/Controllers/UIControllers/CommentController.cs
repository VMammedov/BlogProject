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
    public class CommentController : Controller
    {

        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlogPartial(int id)
        {
            List<Comment> comments = cm.GetList(id);
            return PartialView(comments);
        }
    }
}
