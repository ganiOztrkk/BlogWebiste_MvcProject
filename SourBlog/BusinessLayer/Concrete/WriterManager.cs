using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer entity)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}