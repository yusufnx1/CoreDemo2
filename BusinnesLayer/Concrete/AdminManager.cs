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
    public class AdminManager : IAdminService
    {
        IAdminDal adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            this.adminDal = adminDal;
        }

        public Admin GetById(int id)
        {
            return adminDal.GetById(id);
        }

        public List<Admin> GetList()
        {
           return adminDal.GetListAll();
        }

        public void TAdd(Admin t)
        {
            adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            adminDal.Delete(t);
        }

        public void TUpdate(Admin t)
        {
          adminDal.Update(t);
        }
    }
}
