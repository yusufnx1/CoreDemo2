using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.ViewComponents.Writer
{
    public class WriterNoification:ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
