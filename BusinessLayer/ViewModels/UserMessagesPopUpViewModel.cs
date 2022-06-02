using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserMessagesPopUpViewModel
    {
        public int MessageID { get; set; }
        public int ReceiverID { get; set; }
        public AppUser Receiver { get; set; }
        public int SenderID { get; set; }
        public AppUser Sender { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
