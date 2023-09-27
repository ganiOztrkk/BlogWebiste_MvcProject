using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        private readonly IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public List<Heading> List()
        {
            return _headingDal.List();
        }

        public void Insert(Heading entity)
        {
            _headingDal.Insert(entity);
        }

        public void Delete(Heading entity)
        {
            _headingDal.Delete(entity);
        }

        public void Update(Heading entity)
        {
            _headingDal.Update(entity);
        }

        public Heading GetById(int id)
        {
            return _headingDal.GetById(id);
        }
    }
}