using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T> where T : class
    {
        List<T> List();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}