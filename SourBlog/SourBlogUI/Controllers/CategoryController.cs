using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace SourBlogUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            var categories = _categoryManager.GetAll();
            return View(categories);
        }
    }
}