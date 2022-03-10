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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public Notification GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetListAll();
        }

        public List<Notification> GetNotificationsListByWriter(int id)
        {
            return _notificationDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Notification obj)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification obj)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification obj)
        {
            throw new NotImplementedException();
        }
    }
}
