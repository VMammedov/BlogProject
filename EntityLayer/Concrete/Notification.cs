using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationType { get; set; }
        public string NotificationDetails { get; set; }
        public bool NotificationStatus { get; set; }
        public DateTime NotificationDate { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
