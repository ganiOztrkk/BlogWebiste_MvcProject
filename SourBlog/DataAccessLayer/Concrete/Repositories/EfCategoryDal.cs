using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}