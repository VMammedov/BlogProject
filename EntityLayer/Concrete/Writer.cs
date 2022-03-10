using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterNickName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }
        public string WriterMail { get; set; }
        public string WriterImage { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
        public int? CountryID { get; set; }
        public virtual Country Country { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Notification> Notifications { get; set; }
        public virtual ICollection<Message> SentMessages { get; set; }
        public virtual ICollection<Message> ReceivedMessages { get; set; }
    }
}
