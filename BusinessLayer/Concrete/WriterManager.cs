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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _writerDal.GetListWithEntities(x=>x.WriterID==id)[0];
        }

        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }

        public void TAdd(Writer obj)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Writer obj)
        {
            obj.WriterStatus = false;
            _writerDal.Update(obj);
        }

        public void TUpdate(Writer obj)
        {
            _writerDal.Update(obj);
        }

        public void WriterAdd(RegisterDto writerdto)
        {
            Writer writer = new Writer
            {
                WriterMail = writerdto.Mail,
                WriterNickName = writerdto.NickName,
                WriterName = writerdto.Name,
                WriterSurName = writerdto.SurName,
                WriterPassword = writerdto.Password1,
                CountryID = writerdto.CountryID,
                WriterStatus = true
            };
            _writerDal.Insert(writer);
        }

        public List<Writer> GetListByCountry(string country)
        {
            return _writerDal.GetListAll(x => x.Country.country == country);
        }

        public List<Writer> GetListWithEntities()
        {
            return _writerDal.GetListWithEntities();
        }
    }
}
