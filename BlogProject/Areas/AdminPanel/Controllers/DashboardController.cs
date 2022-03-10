using BlogProject.Areas.AdminPanel.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ViewModels;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using X.PagedList;

namespace BlogProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            List<CategoryDashboardViewModel> categories = new List<CategoryDashboardViewModel>();
            foreach(Category item in cm.GetList())
            {
                CategoryDashboardViewModel category = new CategoryDashboardViewModel
                {
                    CategoryID = item.CategoryID,
                    CategoryName = item.CategoryName,
                    CategoryDescription = item.CategoryDescription,
                    CategoryStatus = item.CategoryStatus
                };
                categories.Add(category);
            };
            return View(categories.ToPagedList(page, 6));
        }

        public IActionResult ExportToExcel()
        {
            using(XLWorkbook workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Category List");
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Category Name";
                worksheet.Cell(1, 3).Value = "Category's Blogs Count";
                worksheet.Cell(1, 4).Value = "Status";

                List<CategoryExcel> categoryExcel = new List<CategoryExcel>();

                foreach (Category item in cm.GetCategoriesWithBlogs())
                {
                    CategoryExcel category = new CategoryExcel
                    {
                        CategoryID = item.CategoryID,
                        CategoryName = item.CategoryName,
                        BlogsCount = item.Blogs.Count(),
                        CategoryStatus = item.CategoryStatus
                    };
                    categoryExcel.Add(category);
                }

                int CurrentRow = 2;
                foreach (CategoryExcel item in categoryExcel)
                {
                    worksheet.Cell(CurrentRow, 1).Value = item.CategoryID;
                    worksheet.Cell(CurrentRow, 2).Value = item.CategoryName;
                    worksheet.Cell(CurrentRow, 3).Value = item.BlogsCount;
                    worksheet.Cell(CurrentRow, 4).Value = item.CategoryStatus;
                    CurrentRow++;
                }

                using(MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    byte[] content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "categories.xlsx");
                }
            }
        }
    }
}