using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
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
