using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> List();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}