using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserAdminListViewModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserImage { get; set; }
        public bool UserStatus { get; set; }
    }
}
