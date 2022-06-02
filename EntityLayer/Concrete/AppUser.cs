using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserImage { get; set; }
        public bool UserStatus { get; set; }
        public int? CountryID { get; set; }
        public virtual Country Country { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<Comment> Comments { get; set; }
        public virtual ICollection<Message> SentMessages { get; set; }
        public virtual ICollection<Message> ReceivedMessages { get; set; }
    }
}