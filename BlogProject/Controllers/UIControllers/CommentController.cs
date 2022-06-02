using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
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

        [HttpPost]
        public IActionResult CommentPost(CommentPostViewModel comment)
        {
            UserManagerBL um = new UserManagerBL(new EfUserRepository());
            Comment CommentObj = new Comment()
            {
                BlogID = comment.blogid,
                CommentContent = comment.content,
                CommentDate = DateTime.Now,
                CommentStatus = true,
                UserID = FunctionHelper.GetUserIdByName(User.Identity.Name),
            };
            cm.TAdd(CommentObj);
            string userimage = um.GetByID(CommentObj.UserID).UserImage;
            return Json(userimage);
        }
    }
}
