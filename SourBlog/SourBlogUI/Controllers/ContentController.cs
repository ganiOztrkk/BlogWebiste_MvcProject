using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;

namespace SourBlogUI.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContentService _contentService = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentByHeading(int id)
        {
            var contents = _contentService.List().Where(x => x.HeadingId == id);
            return View(contents);
        }
    }
}