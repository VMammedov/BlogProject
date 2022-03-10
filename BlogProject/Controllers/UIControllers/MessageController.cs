using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IActionResult Inbox()
        {
            string usermail = User.Identity.Name;
            int id = FunctionHelper.GetWriterIdByMail(usermail);
            List<Message> messages = mm.GetInboxListByWriter(id);
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
            return View(writerMessages);
        }

        public IActionResult MessageDetails(int id)
        {
            Message message = mm.GetByID(id);
            return View(message);
        }
    }
}
