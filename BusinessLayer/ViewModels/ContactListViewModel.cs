using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class ContactListViewModel
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactSurName { get; set; }
        public string ContactMail { get; set; }
        public string ContactSubject { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }
    }
}
