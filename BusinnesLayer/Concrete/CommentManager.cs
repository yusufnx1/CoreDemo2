using BusinnesLayer.Abtrack;
using DataAccessLayer.Abtrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinnesLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommetAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetListAll(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }
    }
}
