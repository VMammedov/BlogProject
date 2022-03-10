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
            file.CopyToAsync(stream);
            return fileName;
        }

        public static int GetWriterIdByMail(string mail)
        {
            int id;
            using (Context c = new Context())
            {
                id = c.Writers.Where(x => x.WriterMail == mail).FirstOrDefault().WriterID;
            }
            return id;
        }

        public static Writer GetWriterByMail(string mail)
        {
            Writer writer = new Writer();
            using(Context c = new Context())
            {
                writer = c.Writers.Where(x => x.WriterMail == mail).FirstOrDefault();
            }
            return writer;
        }
    }
}
