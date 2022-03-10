using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetByID(int id)
        {
            return _adminDal.GetByID(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.GetListAll();
        }

        public void TAdd(Admin obj)
        {
            _adminDal.Insert(obj);
        }

        public void TDelete(Admin obj)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Admin obj)
        {
            _adminDal.Update(obj);
        }
    }
}
