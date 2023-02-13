using BusinnesLayer.Abtrack;
using DataAccessLayer.Abtrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal messageDal;

        public Message2Manager(IMessage2Dal messageDal)
        {
            this.messageDal = messageDal;
        }

        public Message2 GetById(int id)
        {
            return messageDal.GetById(id);
        }

        public List<Message2> GetList()
        {
            return messageDal.GetListAll();
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return messageDal.GetListWhitMessageByWriter(id);
        }

        public void TAdd(Message2 t)
        {
            messageDal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            messageDal.Delete(t);
        }

        public void TUpdate(Message2 t)
        {
            messageDal.Update(t);
        }
    }
}
