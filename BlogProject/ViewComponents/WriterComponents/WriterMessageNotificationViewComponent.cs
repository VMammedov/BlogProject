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

namespace BlogProject.ViewComponents.WriterComponents
{
    public class WriterMessageNotificationViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MessageManager mm = new MessageManager(new EfMessageRepository());
            int id = FunctionHelper.GetWriterIdByMail(User.Identity.Name);
            List<Message> messages = mm.GetInboxListByWriter(id).TakeLast(3).ToList();
            List<WriterMessagesPopUpViewModel> writerMessages = new List<WriterMessagesPopUpViewModel>();
            foreach (Message item in messages)
            {
                WriterMessagesPopUpViewModel message = new WriterMessagesPopUpViewModel
                {
                    MessageID = item.MessageID,
                    SenderID = item.SenderID,
                    Sender = item.Sender,
                    MessageContent = item.MessageContent,
                    Subject = item.Subject,
                    MessageDate = item.MessageDate
                };
                writerMessages.Add(message);
            }
            return View("WriterMessageNotification", writerMessages);
        }
    }
}
