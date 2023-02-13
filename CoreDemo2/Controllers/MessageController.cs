using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo2.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager m2m= new Message2Manager(new EFMessage2Repository());
        public IActionResult Inbox()
        {
            int id = 2;
            var values = m2m.GetInboxListByWriter(id);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            
            var values = m2m.GetById(id);
            return View(values);
        }
    }
}
