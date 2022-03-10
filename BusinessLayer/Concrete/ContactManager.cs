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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetListAll();
        }

        public void TAdd(Contact obj)
        {
            obj.ContactDate = DateTime.Now;
            obj.ContactStatus = true;
            _contactDal.Insert(obj);
        }

        public void TDelete(Contact obj)
        {
            obj.ContactStatus = false;
        }

        public void TUpdate(Contact obj)
        {
            _contactDal.Update(obj);
        }
    }
}
