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
    public class EfUserRepository : GenericRepository<AppUser>, IUserDal
    {
        public List<AppUser> GetListWithEntities(Expression<Func<AppUser, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                        ? context.Users.Include(x => x.Blogs).Include(x=>x.Country).ToList()
                        : context.Users.Where(filter).Include(x => x.Blogs).Include(x => x.Country).ToList();
            }
        }
    }
}
