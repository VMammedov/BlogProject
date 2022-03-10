using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class WriterEditViewModel
    {
        public string WriterNickName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }
        public string WriterMail { get; set; }
        public int CountryID { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterImagePath { get; set; }
    }
}