using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminNickName { get; set; }
        public string AdminMail { get; set; }
        public string Password { get; set; }
        public string AdminImage { get; set; }
        public string Role { get; set; }
    }
}
