using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class BlogCreateViewModel
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public IFormFile BlogThumbnailImage { get; set; }
        public IFormFile BlogImage { get; set; }
        public string BlogThumbnailImagePath { get; set; }
        public string BlogImagePath { get; set; }
        public int CategoryID { get; set; }
    }
}
