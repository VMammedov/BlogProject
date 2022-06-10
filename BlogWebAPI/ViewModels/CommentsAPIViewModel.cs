using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebAPI.ViewModels
{
    public class CommentsAPIViewModel
    {
        public int CommentID { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
    }
}
