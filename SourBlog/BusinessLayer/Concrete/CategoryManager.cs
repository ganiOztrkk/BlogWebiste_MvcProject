using System.Collections.Generic;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : GenericRepository<Category>
    {
        public List<Category> GetAll()
        {
            return List();
        }

        public void CategoryAdd(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName) || category.CategoryName.Length <= 3)
            {
                //error messahe
            }
            else
            {
                Insert(category);
            }
        }

        public void CategoryRemove(Category category)
        {
            Delete(category);
        }
    }
}