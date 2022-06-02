using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        public List<Blog> GetListWithEntities(Expression<Func<Blog, bool>> filter = null);
        public Blog GetBlogByIdWithEntities(int id);
    }
}
