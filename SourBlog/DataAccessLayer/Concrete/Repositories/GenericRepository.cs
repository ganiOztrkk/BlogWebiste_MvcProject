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
        private readonly DbSet<T> _entities;

        public GenericRepository()
        {
            _entities = _context.Set<T>();
        }
        

        public List<T> List()
        {
            return _entities.ToList();
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _entities.Where(filter).ToList();
        }
    }
}