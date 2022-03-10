using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ValidationRules;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    public class WriterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult EditWriter()
        {
            int id = FunctionHelper.GetWriterIdByMail(User.Identity.Name);
            Writer writer = wm.GetByID(id);
            WriterEditViewModel model = new WriterEditViewModel 
            {
                WriterMail = writer.WriterMail,
                CountryID = Convert.ToInt32(writer.CountryID),
                WriterName = writer.WriterName,
                WriterSurName = writer.WriterSurName,
                WriterNickName = writer.WriterNickName,
                WriterImagePath = writer.WriterImage
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditWriter(WriterEditViewModel writerEditModel)
        {
            if (ModelState.IsValid)
            {
                int id = FunctionHelper.GetWriterIdByMail(User.Identity.Name);
                Writer writer = wm.GetByID(id);

                writer.WriterMail = writerEditModel.WriterMail;
                writer.CountryID = writerEditModel.CountryID;
                writer.WriterName = writerEditModel.WriterName;
                writer.WriterSurName = writerEditModel.WriterSurName;
                writer.WriterNickName = writerEditModel.WriterNickName;
                if (writerEditModel.WriterImage!=null)
                {
                    writer.WriterImage = FunctionHelper.UpdateImage(writerEditModel.WriterImage);
                }

                wm.TUpdate(writer);
                return RedirectToAction("Dashboard", "WriterPanel");
            }
            else
            {
                return RedirectToAction("Dashboard", writerEditModel);
            }
        }

        public IActionResult DeleteMyWriterAccount()
        {
            //if (id.ToString() != null)
            //{
            //    wm.TDelete(wm.GetByID(id));
            //}
            return RedirectToAction("Index", "Login");
        }

    }
}