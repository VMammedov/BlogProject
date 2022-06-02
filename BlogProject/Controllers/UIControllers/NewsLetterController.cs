using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{ 
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {

        NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterDal());

        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(string a)
        {
            NewsLetter newsLetter = new NewsLetter();
            newsLetter.Mail = a;
            newsLetter.MailStatus = true;
            nlm.TAdd(newsLetter);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Vusal Mammadli", "xxmixx25@gmail.com"));
            message.To.Add(new MailboxAddress("User", a));
            message.Subject = "Test Message";
            message.Body = new TextPart("plain")
            {
                Text = "Hi dear User, Welcome to our VMBlog family!"
            };

            using(var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("xxmixx25@gmail.com", "vusalavtos");
                client.Send(message);
                client.Disconnect(true);
            }
            return PartialView();
        }
    }
}
