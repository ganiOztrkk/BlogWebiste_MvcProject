using System.Linq;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using System.Web.Mvc;
using System.Web.UI;

namespace SourBlogUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHeadingService _headingService = new HeadingManager(new EfHeadingDal());
        private readonly IContentService _contentService = new ContentManager(new EfContentDal());


        
        public PartialViewResult Index(int id=0)
        {
            var contentList = _contentService.List().Where(x => x.ContentStatus == true && x.HeadingId == id);
            return PartialView(contentList);
        }

        public ActionResult Headings()
        {
            var headings = _headingService.List().Where(x=>x.HeadingStatus == true);

            return View(headings);
        }
    }
}