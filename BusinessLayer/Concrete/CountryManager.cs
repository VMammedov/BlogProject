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
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public Country GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetList()
        {
            return _countryDal.GetListAll();
        }

        public List<Country> GetListWithWriters()
        {
            return _countryDal.GetListWithWriters();
        }

        public void TAdd(Country obj)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Country obj)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Country obj)
        {
            throw new NotImplementedException();
        }
    }
}
