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
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            return View();
        }
    }
}