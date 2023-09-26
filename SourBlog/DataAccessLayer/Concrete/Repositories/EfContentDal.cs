using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
        
    }
}