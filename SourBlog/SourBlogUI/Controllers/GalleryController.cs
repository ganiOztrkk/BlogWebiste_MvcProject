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
    public class GalleryController : Controller
    {
        private readonly IImageFileService _imageFileService = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var images = _imageFileService.List();
            return View(images);
        }
    }
}