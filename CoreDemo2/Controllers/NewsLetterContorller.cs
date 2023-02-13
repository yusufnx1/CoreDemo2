using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.Controllers
{
    public class NewsLetterContorller : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EFNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nlm.TAdd(p);
            return PartialView();
        }
    }
}
