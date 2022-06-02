using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetListAllWithUser(Expression<Func<Message, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                        ? context.Messages.Include(x => x.Sender).Include(y=>y.Receiver).ToList()
                        : context.Messages.Where(filter).Include(x => x.Sender).Include(y => y.Receiver).ToList();
            }
        }

        public Message GetByIDWithUser(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<Message>().Include(x => x.Sender).Include(x => x.Receiver).FirstOrDefault(x=>x.MessageID==id);
            }
        }
    }
}
