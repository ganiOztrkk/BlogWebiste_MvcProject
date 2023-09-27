using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.Repositories;

namespace SourBlogUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService = new ContactManager(new EfContactDal());
        private readonly ContactValidator _contactValidator = new ContactValidator();
        public ActionResult Index()
        {
            ViewBag.Inbox = _contactService.List().Count();
            var contactValues = _contactService.List();
            return View(contactValues);
        }

        public ActionResult MessageDetails(int id)
        {
            var contactValues = _contactService.GetById(id);
            return View(contactValues);
        }

        public ActionResult DeleteMessage(int id)
        {
            var message = _contactService.GetById(id);
            _contactService.Delete(message);
            return RedirectToAction("Index");
        }
    }
}