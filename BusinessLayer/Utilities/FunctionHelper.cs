using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Utilities
{
    public static class FunctionHelper
    {
        public static string UpdateImage(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);
            string fileName = Guid.NewGuid() + extension;
            string location = Path.Combine("C:\\Users\\vusal\\source\\repos\\BlogProject\\BlogProject\\wwwroot/WriterImageFiles/",fileName);
            FileStream stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            return fileName;
        }

        public static string AddBlogImage(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);
            string fileName = Guid.NewGuid() + extension;
            string location = Path.Combine("C:\\Users\\vusal\\source\\repos\\BlogProject\\BlogProject\\wwwroot\\Template/images/", fileName);
            FileStream stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            return ("~/Template/images/"+fileName);
        }

        public static int GetUserIdByName(string UserName)
        {
            int id;
            using (Context c = new Context())
            {
                id = c.Users.Where(x => x.UserName == UserName).FirstOrDefault().Id;
            }
            return id;
        }

        public static int GetUserIdByEmail(string Email)
        {
            int id;
            using (Context c = new Context())
            {
                id = c.Users.Where(x => x.Email == Email).FirstOrDefault().Id;
            }
            return id;
        }

        public static AppUser GetUserByName(string UserName)
        {
            AppUser user = new AppUser();
            using(Context c = new Context())
            {
                user = c.Users.Where(x => x.UserName == UserName).FirstOrDefault();
            }
            return user;
        }

        public static string RemoveHTMLTags(String str)
        {
            System.Text.RegularExpressions.Regex rx =
            new System.Text.RegularExpressions.Regex("<[^>]*>");
            str = rx.Replace(str, "");
            return str;
        }
    }
}
