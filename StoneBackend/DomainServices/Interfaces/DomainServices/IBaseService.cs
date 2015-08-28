using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Interfaces.DomainServices
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
        IEnumerable<T> GetByIds(IEnumerable<int> id);

        bool Insert(T obj);
        bool Insert(IEnumerable<T> obj);

        bool Update(T obj);
        bool Update(IEnumerable<T> obj);

        bool Delete(T obj);
        bool Delete(IEnumerable<T> obj);
    }
}
