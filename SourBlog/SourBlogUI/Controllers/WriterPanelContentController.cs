using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;

namespace SourBlogUI.Controllers
{
    public class WriterPanelContentController : Controller
    {
        private readonly IContentService _contentService = new ContentManager(new EfContentDal());
        private readonly IWriterService _writerService = new WriterManager(new EfWriterDal());

        public ActionResult MyContents()
        {
            var writerMail = (string)Session["WriterMail"];
            var writer = _writerService.List().FirstOrDefault(x => x.WriterMail == writerMail);
            if (writer != null)
            {
                var contents = _contentService.List().Where(x => x.WriterId == writer.WriterId);
                return View(contents);
            }

            return View();
        }
    }
}