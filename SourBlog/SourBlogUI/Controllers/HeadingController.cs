using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace SourBlogUI.Controllers
{
    public class HeadingController : Controller
    {
        private readonly IHeadingService _headingService = new HeadingManager(new EfHeadingDal());
        private readonly ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());
        private readonly IWriterService _writerService = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headings = _headingService.List().Where(x=>x.HeadingStatus==true);
            return View(headings);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> categories = (from item in _categoryService.List()
                                               select new SelectListItem()
                                               {
                                                   Value = item.CategoryId.ToString(),
                                                   Text = item.CategoryName
                                               }).ToList();
            ViewBag.Categories = categories;
            List<SelectListItem> writers = (from item in _writerService.List()
                                            select new SelectListItem()
                                            {
                                                Text = item.WriterName + " " + item.WriterSurname,
                                                Value = item.WriterId.ToString()
                                            }).ToList();
            ViewBag.Writers = writers;

            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            heading.HeadingStatus = true;
            _headingService.Insert(heading);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var heading = _headingService.GetById(id);
            heading.HeadingStatus = false;
            _headingService.Update(heading);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateHeading(int id)
        {
            List<SelectListItem> categories = (from item in _categoryService.List()
                select new SelectListItem()
                {
                    Value = item.CategoryId.ToString(),
                    Text = item.CategoryName
                }).ToList();
            ViewBag.Categories = categories;

            var heading = _headingService.GetById(id);
            return View(heading);
        }

        [HttpPost]
        public ActionResult UpdateHeading(Heading heading)
        {
            heading.HeadingStatus = true;
            _headingService.Update(heading);
            return RedirectToAction("Index");
        }
    }
}