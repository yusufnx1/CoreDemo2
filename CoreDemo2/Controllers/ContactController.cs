using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
namespace CoreDemo2.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            cm.TAdd(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}