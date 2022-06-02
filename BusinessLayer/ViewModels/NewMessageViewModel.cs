using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class NewMessageViewModel
    {
        public string RecieverMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
    }
}