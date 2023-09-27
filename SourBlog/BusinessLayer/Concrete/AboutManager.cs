using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> List()
        {
            return _aboutDal.List();
        }

        public void Insert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }
    }
}