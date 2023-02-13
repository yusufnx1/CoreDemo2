using BusinnesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo2.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            //Api Hava durumu
            //string api = "82fdcc874e08e50957e5146f7a4f9299";
            //string connection = "http://api.openweathermap.org/data/2.5/weather?q=kayseri&mode=xml&lang=tr&units=metric&appid" + api;
            //XDocument document= XDocument.Load(connection);
            //ViewBag.d4 = document.Descendants("temperature").ElementAt(0).Attributes("value");
            return View();
        }
    }
}
