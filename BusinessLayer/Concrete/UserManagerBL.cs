using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManagerBL : IUserService
    {
        IUserDal _userDal;

        public UserManagerBL(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public AppUser GetByID(int id)
        {
            return _userDal.GetListWithEntities(x=>x.Id==id).FirstOrDefault();
        }

        public List<AppUser> GetList()
        {
            return _userDal.GetListAll();
        }

        public void TAdd(AppUser obj)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser obj)
        {
            obj.UserStatus = false;
            _userDal.Update(obj);
        }

        public void TUpdate(AppUser obj)
        {
            _userDal.Update(obj);
        }

        public List<AppUser> GetListByCountry(string country)
        {
            return _userDal.GetListAll(x => x.Country.country == country);
        }

        public List<AppUser> GetListWithEntities()
        {
            return _userDal.GetListWithEntities();
        }
    }
}
