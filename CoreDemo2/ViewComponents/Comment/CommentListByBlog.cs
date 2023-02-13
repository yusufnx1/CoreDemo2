using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreDemo2.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetListAll(id);
            return View(values);
        }
    }
}
