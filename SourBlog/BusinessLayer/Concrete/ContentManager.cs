using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        public List<Content> List()
        {
            throw new NotImplementedException();
        }

        public void Insert(Content entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Content entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Content entity)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> List(Expression<Func<Content, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
