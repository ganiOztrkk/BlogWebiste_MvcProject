using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;

namespace SourBlogUI.Controllers
{
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var writers = _writerService.List();
            return View(writers);
        }
    }
}