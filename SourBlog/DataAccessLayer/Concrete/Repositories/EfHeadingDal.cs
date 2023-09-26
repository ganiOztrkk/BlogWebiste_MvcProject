using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
        
    }
}