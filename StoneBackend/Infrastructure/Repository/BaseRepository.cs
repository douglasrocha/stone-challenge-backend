using DomainModel.Entities;
using DomainModel.Repository.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll()
        {
            using (var context = new BlogContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new BlogContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public IEnumerable<T> GetByIds(IEnumerable<int> ids)
        {
            using (var context = new BlogContext())
            {
                return context.Set<T>().Where(a => ids.Contains(a.Id));
            }
        }

        public int Insert(T obj)
        {
            using (var context = new BlogContext())
            {
                context.Set<T>().Add(obj);
                return context.SaveChanges();
            }
        }

        public int Insert(IEnumerable<T> obj)
        {
            using (var context = new BlogContext())
            {
                context.Set<T>().AddRange(obj);
                return context.SaveChanges();
            } 
        }

        public int Update(T obj)
        {
            using (var context = new BlogContext())
            {
                context.Set<T>().Attach(obj);
                return context.SaveChanges();
            }
        }

        public int Update(IEnumerable<T> obj)
        {
            using (var context = new BlogContext())
            {
                foreach (var item in obj)
                {
                    context.Set<T>().Attach(item);
                }

                return context.SaveChanges();
            }
        }

        public int Delete(T obj)
        {
            using (var context = new BlogContext())
            {
                context.Set<T>().Remove(obj);
                return context.SaveChanges();
            }
        }

        public int Delete(IEnumerable<T> obj)
        {
            using (var context = new BlogContext())
            {
                context.Set<T>().RemoveRange(obj);
                return context.SaveChanges();
            }
        }
    }
}
