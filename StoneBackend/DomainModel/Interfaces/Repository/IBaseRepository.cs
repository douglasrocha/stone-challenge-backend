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

        int Insert(T obj);
        int Insert(IEnumerable<T> obj);

        int Update(T obj);
        int Update(IEnumerable<T> obj);

        int Delete(T obj);
        int Delete(IEnumerable<T> obj);
    }
}
