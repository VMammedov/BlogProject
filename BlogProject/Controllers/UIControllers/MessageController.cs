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
            string username = User.Identity.Name;
            int id = FunctionHelper.GetUserIdByName(username);
            List<Message> messages = mm.GetInboxListByUser(id);
            List<MessageBoxViewModel> userMessages = new List<MessageBoxViewModel>();
            foreach (Message item in messages)
            {
                UserDetailsForMsgViewModel userDetailsForMsg = new UserDetailsForMsgViewModel()
                {
                    SenderNickName = item.Sender.UserName
                };
                MessageBoxViewModel message = new MessageBoxViewModel
                {
                    MessageID = item.MessageID,
                    User = userDetailsForMsg,
                    MessageContent = FunctionHelper.RemoveHTMLTags(item.MessageContent),
                    Subject = item.Subject,
                    MessageDate = item.MessageDate
                };
                userMessages.Add(message);
            }
            return View(userMessages);
        }

        public IActionResult SentBox()
        {
            string username = User.Identity.Name;
            int id = FunctionHelper.GetUserIdByName(username);
            List<Message> messages = mm.GetSentBoxListByUser(id);
            List<MessageBoxViewModel> userMessages = new List<MessageBoxViewModel>();
            foreach (Message item in messages)
            {
                UserDetailsForMsgViewModel userDetailsForMsg = new UserDetailsForMsgViewModel()
                {
                    ReceiverNickName = item.Receiver.UserName
                };
                MessageBoxViewModel message = new MessageBoxViewModel
                {
                    MessageID = item.MessageID,
                    User = userDetailsForMsg,
                    MessageContent = FunctionHelper.RemoveHTMLTags(item.MessageContent),
                    Subject = item.Subject,
                    MessageDate = item.MessageDate
                };
                userMessages.Add(message);
            }
            return View(userMessages);
        }

        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(NewMessageViewModel messageViewModel)
        {
            if(ModelState.IsValid)
            {
                Message message = new Message()
                {
                    SenderId = FunctionHelper.GetUserIdByName(User.Identity.Name),
                    MessageContent = messageViewModel.MessageContent,
                    ReceiverId = FunctionHelper.GetUserIdByEmail(messageViewModel.RecieverMail),
                    Subject = messageViewModel.Subject,
                    MessageDate = DateTime.Now
                };
                mm.TAdd(message);
                return RedirectToAction("Inbox");
            }
            else
            {
                return RedirectToAction("ErrorForNotEligibleOperation", "Error");
            }
        }

        public IActionResult InboxMessageDetails(int id)
        {
            Message message = mm.GetByID(id);
            UserDetailsForMsgViewModel userDetailsForMsg = new UserDetailsForMsgViewModel()
            {
                ReceiverNickName = message.Receiver.UserName,
                ReceiverMail= message.Receiver.Email,
                SenderNickName = message.Sender.UserName,
                SenderMail = message.Sender.Email,
                SenderImage = message.Sender.UserImage
            };
            MessageBoxViewModel messageVM = new MessageBoxViewModel
            {
                MessageID = message.MessageID,                
                User = userDetailsForMsg,
                MessageContent = message.MessageContent,
                Subject = message.Subject,
                MessageDate = message.MessageDate
            };
            return View(messageVM);
        }

        public IActionResult SentboxMessageDetails(int id)
        {
            Message message = mm.GetByID(id);
            UserDetailsForMsgViewModel userDetailsForMsg = new UserDetailsForMsgViewModel()
            {
                ReceiverNickName = message.Receiver.UserName,
                ReceiverMail = message.Receiver.Email,
                SenderMail = message.Sender.Email,
                ReceiverImage = message.Receiver.UserImage
            };
            MessageBoxViewModel messageVM = new MessageBoxViewModel
            {
                MessageID = message.MessageID,
                User = userDetailsForMsg,
                MessageContent = message.MessageContent,
                Subject = message.Subject,
                MessageDate = message.MessageDate
            };
            return View(messageVM);
        }
    }
}