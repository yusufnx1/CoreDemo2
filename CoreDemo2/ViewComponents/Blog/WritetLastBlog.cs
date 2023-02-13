using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo2.ViewComponents.Blog
{
    public class WritetLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = bm.GetBlogListWriter(id);
            return View();
        }
    }
}
