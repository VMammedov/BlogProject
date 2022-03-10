using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public List<Category> GetListWithBlogs(Expression<Func<Category, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                        ? context.Categories.Include(x => x.Blogs).ToList()
                        : context.Categories.Where(filter).Include(x => x.Blogs).ToList();
            }
        }
    }
}
