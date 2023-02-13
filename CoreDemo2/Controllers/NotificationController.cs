using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;

namespace CoreDemo2.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
