using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class BaseAppService<T> : IBaseAppService<T> where T : BaseEntity
    {
        private readonly IBaseService<T> _service;

        public BaseAppService(IBaseService<T> service)
        {
            _service = service;
        }

        public IEnumerable<T> GetAll()
        {
            return _service.GetAll();
        }

        public T GetById(int id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<T> GetByIds(IEnumerable<int> id)
        {
            return _service.GetByIds(id);
        }

        public int Insert(T obj)
        {
            return _service.Insert(obj);
        }

        public int Insert(IEnumerable<T> obj)
        {
            return _service.Insert(obj);
        }

        public int Update(T obj)
        {
            return _service.Update(obj);
        }

        public int Update(IEnumerable<T> obj)
        {
            return _service.Update(obj);
        }

        public int Delete(T obj)
        {
            return _service.Delete(obj);
        }

        public int Delete(IEnumerable<T> obj)
        {
            return _service.Delete(obj);
        }
    }
}
