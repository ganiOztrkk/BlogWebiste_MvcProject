using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace SourBlogUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());

        public ActionResult GetList()
        {
            var categories = _categoryService.List();
            return View(categories);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                category.CategoryStatus = true;
                _categoryService.Insert(category);
                return RedirectToAction("GetList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
    }
}