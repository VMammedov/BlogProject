using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserEditViewModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserMail { get; set; }
        public int CountryID { get; set; }
        public IFormFile UserImage { get; set; }
        public string UserImagePath { get; set; }
    }
}