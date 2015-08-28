using DomainModel.Entities;
using DomainModel.Exceptions;
using DomainModel.Interfaces.DomainServices;
using DomainModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
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

        public int Insert(T obj)
        {
            if (!obj.IsValid())
            {
                throw new DomainException();
            }

            return _repository.Insert(obj);
        }

        public int Insert(IEnumerable<T> obj)
        {
            if (!obj.All(a => a.IsValid()))
            {
                throw new DomainException();
            }

            return _repository.Insert(obj);
        }

        public int Update(T obj)
        {
            if (!obj.IsValid())
            {
                throw new DomainException();
            }

            return _repository.Update(obj);
        }

        public int Update(IEnumerable<T> obj)
        {
            if (!obj.All(a => a.IsValid()))
            {
                throw new DomainException();
            }

            return _repository.Update(obj);
        }

        public int Delete(T obj)
        {
            return _repository.Delete(obj);
        }

        public int Delete(IEnumerable<T> obj)
        {
            return _repository.Delete(obj);
        }
    }
}
