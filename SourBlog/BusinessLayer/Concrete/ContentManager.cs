using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        private readonly IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> List()
        {
            return _contentDal.List();
        }

        public void Insert(Content entity)
        {
            _contentDal.Insert(entity);
        }

        public void Delete(Content entity)
        {
            _contentDal.Delete(entity);
        }

        public void Update(Content entity)
        {
            _contentDal.Update(entity);
        }

        public Content GetById(int id)
        {
            return _contentDal.GetById(id);
        }

    }
}
