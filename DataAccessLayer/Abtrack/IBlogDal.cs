using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abtrack
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetlistWhitCategory();
        List<Blog> GetListWhitCategoryByWriter(int id);
    }
}
