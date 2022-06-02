using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.UserComponents
{
    public class UserNotificationViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            int id = FunctionHelper.GetUserIdByName(User.Identity.Name);
            NotificationManager nm = new NotificationManager(new EfNotificationRepository());
            List<Notification> notifications = nm.GetNotificationsListByUser(id).TakeLast(5).ToList();
            return View("UserNotification", notifications);
        }
    }
}
