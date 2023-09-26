using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        public List<Heading> List()
        {
            throw new NotImplementedException();
        }

        public void Insert(Heading entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Heading entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Heading entity)
        {
            throw new NotImplementedException();
        }

        public Heading GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Heading> List(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}