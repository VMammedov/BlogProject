using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers.UIControllers
{
    public class WriterPanelController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());
            List<int> values = new List<int>();
            values.Add(wm.GetByID(1).Blogs.Count());
            return View(values);
        }

        //List<int> values = new List<int>();
        //TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);
        //values.Add(wm.GetList().Count());
        //values.Add(wm.GetListWithEntities()[0].Blogs.Count());
        //values.Add(wm.GetListWithEntities()[0].Blogs.Count(x=> DateTime.Compare(x.BlogCreateDate, DateTime.Now.Subtract(aMonth))==1));
    }
}
