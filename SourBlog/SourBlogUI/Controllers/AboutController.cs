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
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var about = _aboutService.List().Where(x=>x.AboutStatus==true);
            return View(about);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            about.AboutStatus = true;
            _aboutService.Insert(about);
            return RedirectToAction("Index");
        }

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = _aboutService.GetById(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(int id)
        {
            var about = _aboutService.GetById(id);
            about.AboutStatus = false;
            _aboutService.Update(about);
            return RedirectToAction("Index");
        }
    }
}