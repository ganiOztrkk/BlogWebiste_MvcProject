using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> List()
        {
            return _messageDal.List();
        }

        public void Insert(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }
    }
}