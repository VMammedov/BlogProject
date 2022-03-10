using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class RegisterDto
    {
        public string NickName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Mail { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public int CountryID { get; set; }
    }
}
