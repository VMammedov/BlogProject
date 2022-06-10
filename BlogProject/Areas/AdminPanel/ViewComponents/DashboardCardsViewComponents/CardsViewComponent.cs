using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlogProject.Areas.AdminPanel.ViewComponents.DashboardCardsViewComponents
{
    public class CardsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            string apiID = "7aac6792c70f1fc0d0be824412b0014d";
            List<string> data = new List<string>();
            data.Add(bm.GetList().Count.ToString());
            data.Add(cm.GetList().Count.ToString());
            try
            {
                string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&mode=xml&units=metric&appid=" + apiID;
                XDocument document = XDocument.Load(connection);
                if (document != null)
                {
                    data.Add(document.Descendants("city").ElementAt(0).Attribute("name").Value.ToString());
                    data.Add(document.Descendants("temperature").ElementAt(0).Attribute("value").Value.ToString());
                    data.Add(document.Descendants("speed").ElementAt(0).Attribute("value").Value.ToString());
                }
                return View("Cards", data);
            }
            catch (Exception)
            {
                for (int i = 2; i < 5; i++)
                {
                    data.Add("No data");
                }
                return View("Cards", data);
            }
        }
    }
}
