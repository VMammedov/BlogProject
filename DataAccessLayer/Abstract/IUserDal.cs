using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IGenericDal<AppUser>
    {
        public List<AppUser> GetListWithEntities(Expression<Func<AppUser, bool>> filter = null);
    }
}
