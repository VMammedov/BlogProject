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
    public class MessageManager : IMessageService
    {

        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.GetByIDWithUser(id);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public List<Message> GetInboxListByUser(int id)
        {
            return _messageDal.GetListAllWithUser(x=>x.ReceiverId==id);
        }

        public List<Message> GetSentBoxListByUser(int id)
        {
            return _messageDal.GetListAllWithUser(x => x.SenderId == id);
        }

        public void TAdd(Message obj)
        {
            _messageDal.Insert(obj);
        }

        public void TDelete(Message obj)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message obj)
        {
            throw new NotImplementedException();
        }
    }
}