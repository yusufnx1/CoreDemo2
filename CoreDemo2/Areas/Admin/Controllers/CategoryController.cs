using BusinnesLayer.Concrete;
using BusinnesLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using X.PagedList;

namespace CoreDemo2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page,8);
            return View(values);
        }
        [HttpGet]
        public IActionResult NewCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewCategory(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult result = cv.Validate(p);
            if (result.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
        }
        public IActionResult CategoryDelete(int id)
        {
            var values = cm.GetById(id);
            cm.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
