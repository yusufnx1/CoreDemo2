using DataAccessLayer.Abtrack;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetlistWhitCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(b => b.Category).ToList();
            };
        }

        public List<Blog> GetListWhitCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(b => b.Category).Where(x => x.WriterId == id).ToList();
            };
        }
    }
}
