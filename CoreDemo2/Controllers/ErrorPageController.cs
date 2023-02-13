using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
