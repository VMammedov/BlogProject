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
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public List<Writer> GetListWithEntities(Expression<Func<Writer, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                        ? context.Writers.Include(x => x.Blogs).Include(x=>x.Country).ToList()
                        : context.Writers.Where(filter).Include(x => x.Blogs).Include(x => x.Country).ToList();
            }
        }
    }
}
