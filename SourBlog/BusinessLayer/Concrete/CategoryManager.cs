using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> List()
        {
            return _categoryDal.List();
        }

        public void Insert(Category entity)
        {
                
            _categoryDal.Insert(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }
    }
}