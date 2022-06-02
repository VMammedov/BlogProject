using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Areas.AdminPanel.Models
{
    public class CategoryInfo
    {
        public string categoryname { get; set; }
        public string categorydescription { get; set; }
        public int blogscount { get; set; }
    }
}
