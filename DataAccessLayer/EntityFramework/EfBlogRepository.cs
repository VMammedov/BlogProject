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
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithEntities(Expression<Func<Blog, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                        ? context.Blogs.Include(x => x.Category).Include(x => x.User).Include(x=>x.Comments).ToList()
                        : context.Blogs.Where(filter).Include(x => x.Category).Include(x => x.User).Include(x => x.Comments).ToList();
            }
        }

        public Blog GetBlogByIdWithEntities(int id)
        {
            using (Context context = new Context())
            {
                return context.Blogs.Where(e=>e.BlogID==id).Include(x => x.Category).Include(x => x.User).Include(x => x.Comments).FirstOrDefault();
            }
        }
    }
}
