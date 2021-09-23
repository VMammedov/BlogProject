using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using Context c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using Context c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using Context c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using Context c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using Context c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
