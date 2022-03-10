using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T obj);
        void TDelete(T obj);
        void TUpdate(T obj);
        List<T> GetList();
        T GetByID(int id);
    }
}
