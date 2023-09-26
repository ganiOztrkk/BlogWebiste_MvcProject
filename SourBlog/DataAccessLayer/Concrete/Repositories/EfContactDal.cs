using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        
    }
}