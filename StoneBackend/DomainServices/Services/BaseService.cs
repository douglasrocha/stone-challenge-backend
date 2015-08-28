using DomainModel.Interfaces.DomainServices;
using DomainModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetByIds(IEnumerable<int> id)
        {
            return _repository.GetByIds(id);
        }

        public bool Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public bool Insert(IEnumerable<T> obj)
        {
            return _repository.Insert(obj);
        }

        public bool Update(T obj)
        {
            return _repository.Update(obj);
        }

        public bool Update(IEnumerable<T> obj)
        {
            return _repository.Update(obj);
        }

        public bool Delete(T obj)
        {
            return _repository.Delete(obj);
        }

        public bool Delete(IEnumerable<T> obj)
        {
            return _repository.Delete(obj);
        }
    }
}
