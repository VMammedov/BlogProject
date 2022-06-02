using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        public List<Category> GetCategoriesWithBlogs();
        public Category GetCategoryWithBlogs(int id);
    }
}
