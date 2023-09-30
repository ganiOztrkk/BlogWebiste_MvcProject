using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    public class WriterPanelController : Controller
    {
        private readonly IHeadingService _headingService = new HeadingManager(new EfHeadingDal());
        private readonly ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());
        private readonly IWriterService _writerService = new WriterManager(new EfWriterDal());
        private readonly WriterValidator _writerValidator = new WriterValidator();

        [HttpGet]
        public ActionResult WriterProfile()
        {
            var writerMail = (string)Session["WriterMail"];
            var writerInfo = _writerService.List().FirstOrDefault(x => x.WriterMail == writerMail);
            if (writerInfo != null)
            {
                var writer = _writerService.GetById(writerInfo.WriterId);
                return View(writer);
            }
            return RedirectToAction("WriterLogin", "Login");
        }
        [HttpPost]
        public ActionResult UpdateWriter(Writer writer)
        {
            ValidationResult validationResult = _writerValidator.Validate(writer);
            if (validationResult.IsValid)
            {
                _writerService.Update(writer);
                return RedirectToAction("WriterProfile");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }


        public ActionResult MyHeadings()
        {
            var writerMail = (string)Session["WriterMail"];
            var writer = _writerService.List().FirstOrDefault(x => x.WriterMail == writerMail);

            if (writer != null)
            {
                var headings = _headingService.List().Where(x => x.WriterId == writer.WriterId && x.HeadingStatus == true);
                return View(headings);
            }
            return View();
        }

        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> categories = (from item in _categoryService.List()
                                               select new SelectListItem()
                                               {
                                                   Value = item.CategoryId.ToString(),
                                                   Text = item.CategoryName
                                               }).ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public ActionResult NewHeading(Heading heading)
        {
            var writerMail = (string)Session["WriterMail"];
            var writer = _writerService.List().FirstOrDefault(x => x.WriterMail == writerMail);
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            if (writer != null) heading.WriterId = writer.WriterId;
            heading.HeadingStatus = true;
            _headingService.Insert(heading);
            return RedirectToAction("MyHeadings");
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
            return RedirectToAction("MyHeadings");
        }

        public ActionResult DeleteHeading(int id)
        {
            var heading = _headingService.GetById(id);
            heading.HeadingStatus = false;
            _headingService.Update(heading);
            return RedirectToAction("MyHeadings");
        }
    }
}