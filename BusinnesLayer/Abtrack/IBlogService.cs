using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abtrack
{
    internal interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogListWhitCategory();
        List<Blog> GetBlogListWriter(int id);
    }
}
