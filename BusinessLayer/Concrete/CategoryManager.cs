using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void TAdd(Category obj)
        {
            _categoryDal.Insert(obj);
        }

        public void TDelete(Category obj)
        {
            _categoryDal.Delete(obj);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TUpdate(Category obj)
        {
            _categoryDal.Update(obj);
        }

        public List<Category> GetCategoriesWithBlogs()
        {
            return _categoryDal.GetListWithBlogs();
        }

        public Category GetCategoryWithBlogs(int id)
        {
            return _categoryDal.GetListWithBlogs(x => x.CategoryID == id).FirstOrDefault();
        }
    }
}
