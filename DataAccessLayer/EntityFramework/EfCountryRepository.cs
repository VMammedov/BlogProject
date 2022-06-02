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
    public class EfCountryRepository : GenericRepository<Country>, ICountryDal
    {
        public List<Country> GetListWithUsers(Expression<Func<Country, bool>> filter = null)
        {
            using( Context context = new Context())
            {
                return filter == null ? context.Countries.Include(x => x.Users).ToList() :
                context.Countries.Where(filter).Include(x => x.Users).ToList();
            }
        }
    }
}
