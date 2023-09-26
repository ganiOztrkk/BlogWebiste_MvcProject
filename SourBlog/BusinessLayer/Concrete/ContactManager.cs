using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        public List<Contact> List()
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> List(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}