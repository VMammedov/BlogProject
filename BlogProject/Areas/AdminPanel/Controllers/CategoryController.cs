using BlogProject.Areas.AdminPanel.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Areas.AdminPanel.Controllers
{
    [AllowAnonymous]
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryAddEditViewModel viewcategory)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = viewcategory.CategoryName,
                    CategoryDescription = viewcategory.CategoryDescription,
                    CategoryStatus = true
                };
                cm.TAdd(category);
                return RedirectToAction("Index", "Dashboard");
            }
            else
                return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            Category category = cm.GetByID(id);
            category.CategoryStatus = false;
            cm.TUpdate(category);
            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult CategoryChart()
        {
            List<Category> categories = cm.GetCategoriesWithBlogs();
            List<CategoryChart> chartCategories = new List<CategoryChart>();

            foreach (Category item in categories)
            {
                CategoryChart chartCategory = new CategoryChart
                {
                    categoryname = item.CategoryName,
                    blogscount = item.Blogs.Count
                };
                chartCategories.Add(chartCategory);
            }

            return Json(new { jsonlist = chartCategories });
        }
    }
}
