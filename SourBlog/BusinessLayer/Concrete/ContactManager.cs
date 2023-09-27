using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> List()
        {
            return _contactDal.List();
        }

        public void Insert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

    }
}