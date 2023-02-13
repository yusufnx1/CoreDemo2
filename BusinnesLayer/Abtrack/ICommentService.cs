using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinnesLayer.Abtrack
{
    public interface ICommentService 
    {
        List<Comment> GetListAll(int id);
        void CommetAdd(Comment comment);
    }
}
