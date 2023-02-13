using BusinnesLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo2.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();

            ViewBag.deger1 = c.Blogs.Count();
            ViewBag.deger2 = c.Blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.deger3=c.Categories.Count();
            return View();
        }
    }
}
