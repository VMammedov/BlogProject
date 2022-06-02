using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserDetailsForMsgViewModel
    {
        public string ReceiverNickName { get; set; }
        public string ReceiverMail { get; set; }
        public string ReceiverImage { get; set; }
        public string SenderNickName { get; set; }
        public string SenderMail { get; set; }
        public string SenderImage { get; set; }
    }
}
