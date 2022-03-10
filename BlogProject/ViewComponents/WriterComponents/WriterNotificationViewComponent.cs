using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.WriterComponents
{
    public class WriterNotificationViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            int id = FunctionHelper.GetWriterIdByMail(User.Identity.Name);
            NotificationManager nm = new NotificationManager(new EfNotificationRepository());
            List<Notification> notifications = nm.GetNotificationsListByWriter(id).TakeLast(5).ToList();
            return View("WriterNotification", notifications);
        }
    }
}
