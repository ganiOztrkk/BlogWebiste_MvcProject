using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SourBlogUI.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            return View();
        }
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}