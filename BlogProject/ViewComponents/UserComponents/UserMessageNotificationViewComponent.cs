using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.UserComponents
{
    public class UserMessageNotificationViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MessageManager mm = new MessageManager(new EfMessageRepository());
            int id = FunctionHelper.GetUserIdByName(User.Identity.Name);
            List<Message> messages = mm.GetInboxListByUser(id).TakeLast(3).ToList();
            List<UserMessagesPopUpViewModel> userMessages = new List<UserMessagesPopUpViewModel>();
            foreach (Message item in messages)
            {
                UserMessagesPopUpViewModel message = new UserMessagesPopUpViewModel
                {
                    MessageID = item.MessageID,
                    SenderID = (int)item.SenderId,
                    Sender = item.Sender,
                    MessageContent = FunctionHelper.RemoveHTMLTags(item.MessageContent),
                    Subject = item.Subject,
                    MessageDate = item.MessageDate
                };
                userMessages.Add(message);
            }
            return View("UserMessageNotification", userMessages);
        }
    }
}
