﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        public List<Message> GetListAllWithUser(Expression<Func<Message, bool>> filter = null);
        public Message GetByIDWithUser(int id);
    }
}
