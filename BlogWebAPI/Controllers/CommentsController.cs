using BlogWebAPI.ViewModels;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        CommentManager cm = new CommentManager(new EfCommentRepository());

        /// <summary>
        /// Get Comments By Blog Id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                List<Comment> CommentsList = cm.GetList(id).ToList();
                List<CommentsAPIViewModel> ViewModelList = new List<CommentsAPIViewModel>();
                foreach (var item in CommentsList)
                {
                    CommentsAPIViewModel viewModel = new CommentsAPIViewModel
                    {
                        CommentID = item.CommentID,
                        CommentContent = item.CommentContent,
                        CommentDate = item.CommentDate,
                        UserName = item.User.UserName,
                        UserMail = item.User.Email
                    };
                    ViewModelList.Add(viewModel);
                }
                return JsonConvert.SerializeObject(ViewModelList);
            }
            catch (Exception e)
            {
                return $"Something went Wrong! \n {e.Message}";
            }
        }
    }
}
