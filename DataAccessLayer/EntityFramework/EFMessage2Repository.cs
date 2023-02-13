﻿using DataAccessLayer.Abtrack;
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
    public class EFMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWhitMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages2.Include(x => x.SenderUser).Where(y => y.SenderId == id).ToList();
            }
        }
    }
}
