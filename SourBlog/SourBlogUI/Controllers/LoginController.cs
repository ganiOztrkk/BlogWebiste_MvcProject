using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace SourBlogUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context context = new Context();
            var adminUserInfo = context.Admins.FirstOrDefault(x=>x.AdminUsername == admin.AdminUsername && x.AdminPassword == admin.AdminPassword);
            if (adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminUsername,false);
                Session["AdminUsername"] = adminUserInfo.AdminUsername;
                Session["AdminImage"] = adminUserInfo.AdminImage;
                return RedirectToAction("GetList", "Category");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer writer)
        {
            Context context = new Context();
            var writerUserInfo = context.Writers.FirstOrDefault(x =>
                x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (writerUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerUserInfo.WriterMail,false);
                Session["WriterMail"]=writerUserInfo.WriterMail;
                Session["WriterImage"] = writerUserInfo.WriterImage;
                Session["WriterName"] = writerUserInfo.WriterName + " " + writerUserInfo.WriterSurname;
                return RedirectToAction("MyHeadings", "WriterPanel");
            }

            return RedirectToAction("WriterLogin");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Headings","Default");
        }
    }
}