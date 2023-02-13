using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminFooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView();
        }
    }
}
