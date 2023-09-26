using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepositoryDal<T> where T : class, IEntity
    {
        private readonly Context _context = new Context();

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}