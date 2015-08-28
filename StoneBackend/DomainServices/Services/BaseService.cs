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
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByIds(IEnumerable<int> id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IEnumerable<T> obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(IEnumerable<T> obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IEnumerable<T> obj)
        {
            throw new NotImplementedException();
        }
    }
}
