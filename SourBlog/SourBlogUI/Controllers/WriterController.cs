using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace SourBlogUI.Controllers
{
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService = new WriterManager(new EfWriterDal());
        private readonly WriterValidator _writerValidator = new WriterValidator();

        public ActionResult Index()
        {
            var writers = _writerService.List().Where(x=>x.WriterStatus==true);
            return View(writers);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            
            ValidationResult validationResult = _writerValidator.Validate(writer);
            if (validationResult.IsValid)
            {
                _writerService.Insert(writer);
                return RedirectToAction("Index");
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

        [HttpGet]
        public ActionResult UpdateWriter(int id)
        {
            var writer = _writerService.GetById(id);
            return View(writer);
        }

        [HttpPost]
        public ActionResult UpdateWriter(Writer writer)
        {
            ValidationResult validationResult = _writerValidator.Validate(writer);
            if (validationResult.IsValid)
            {
                _writerService.Update(writer);
                return RedirectToAction("Index");
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

        public ActionResult DeleteWriter(int id)
        {
            var writer = _writerService.GetById(id);
            writer.WriterStatus = false;
            _writerService.Update(writer);
            return RedirectToAction("Index");
        }
    }
}