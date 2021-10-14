using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents.CategoryComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<Category> categories = cm.GetList();
            return View("CategoryList", categories);
        }

    }
}
