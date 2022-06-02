using BusinessLayer.Concrete;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BlogProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index(int page=1)
        {
            List<ContactListViewModel> contacts = new List<ContactListViewModel>();
            foreach(Contact item in cm.GetList())
            {
                ContactListViewModel contact = new ContactListViewModel
                {
                    ContactID = item.ContactID,
                    ContactName = item.ContactName,
                    ContactSurName = item.ContactSurName,
                    ContactMail = item.ContactMail,
                    ContactSubject = item.ContactSubject,
                    ContactDate = item.ContactDate,
                    ContactStatus = item.ContactStatus
                };
                contacts.Add(contact);
            };
            return View(contacts.OrderByDescending(x => x.ContactID).ToList().ToPagedList(page, 8));
        }

        public JsonResult ContactDetails(int id)
        {
            Contact contact = cm.GetByID(id);
            string data = JsonConvert.SerializeObject(contact);
            return Json(data);
        }

        public IActionResult SendResponseEmail(string email, string message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Vusal Mammadli", "xxmixx25@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", email));
            mimeMessage.Subject = "Reply from WeBlog to your Message";
            using (StreamReader SourceReader = System.IO.File.OpenText("C:\\Users\\vusal\\source\\repos\\BlogProject\\BlogProject\\wwwroot\\Template\\EmailTemplate.txt"))
            {
                mimeMessage.Body = new TextPart("html")
                {
                    Text = SourceReader.ReadToEnd()
                };
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("xxmixx25@gmail.com", "vusalavtos");
                client.Send(mimeMessage);
                client.Disconnect(true);
            }
            return Json("");
        }
    }
}
