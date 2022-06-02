using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserInfoViewModel
    {
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserMail { get; set; }
        public string UserImage { get; set; }
        public bool UserStatus { get; set; }
        public string Country { get; set; }
        public int BlogsCount { get; set; }
    }
}
