using ClosedXML.Excel;
using CoreDemo2.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Presentation;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace CoreDemo2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {

        public IActionResult ExpertStaticBlogList()
        {
            // Excel İşlemi
            using (var worksBook = new XLWorkbook())
            {
                var worksSheet = worksBook.Worksheets.Add("Blog Listesi");
                worksSheet.Cell(1, 1).Value = "Blog ID";
                worksSheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksSheet.Cell(BlogRowCount, 1).Value = item.BlogId;
                    worksSheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    worksBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma.xlxs");
                }
            }
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{BlogId=1, BlogName="C# Programlama" },
                new BlogModel{BlogId=2, BlogName="Pyhton Programlama Dili" },
            };
            return bm;
        }
        public IActionResult BlogListExcel()
        {
            return View();
        }
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var worksBook = new XLWorkbook())
            {
                var worksSheet = worksBook.Worksheets.Add("Blog Listesi");
                worksSheet.Cell(1, 1).Value = "Blog ID";
                worksSheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksSheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksSheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    worksBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma.xlxs");
                }
            }
        }
        public List<BlogModel2> BlogTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using (var c = new Context())
            {
                //bm = c.Blogs.Select(x => new BlogModel2
                //{
                //    Id = x.BlogId,
                //    BlogName=x.BlogTitle
                //}).ToList();
            }
            return bm;
        }
        public IActionResult BlogTitleListExcel()
        {
            return View();
        }
    }
}
