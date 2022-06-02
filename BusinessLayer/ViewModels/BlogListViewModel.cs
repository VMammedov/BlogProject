using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class BlogListViewModel
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public string Category { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int CommentsCount { get; set; }
        public float BlogRating { get; set; }
    }
}
