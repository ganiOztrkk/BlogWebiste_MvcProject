using DataAccessLayer.Abstract;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
    }
}