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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public NewsLetter GetByID(int id)
        {
            return _newsLetterDal.GetByID(id);
        }

        public List<NewsLetter> GetList()
        {
            return _newsLetterDal.GetListAll();
        }

        public void TAdd(NewsLetter obj)
        {
            obj.MailStatus = true;
            _newsLetterDal.Insert(obj);
        }

        public void TDelete(NewsLetter obj)
        {
            obj.MailStatus = false;
        }

        public void TUpdate(NewsLetter obj)
        {
            _newsLetterDal.Update(obj);
        }
    }
}
