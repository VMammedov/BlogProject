using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICountryDal : IGenericDal<Country>
    {
        public List<Country> GetListWithUsers(Expression<Func<Country, bool>> filter = null);
    }
}
