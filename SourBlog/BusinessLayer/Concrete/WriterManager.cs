using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> List()
        {
            return _writerDal.List();
        }

        public void Insert(Writer entity)
        {
            _writerDal.Insert(entity);
        }

        public void Delete(Writer entity)
        {
            _writerDal.Delete(entity);
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }

        public Writer GetById(int id)
        {
            return _writerDal.GetById(id);
        }
    }
}