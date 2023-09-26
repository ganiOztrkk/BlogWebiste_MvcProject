using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        
    }
}