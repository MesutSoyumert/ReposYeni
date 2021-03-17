using EntityFrameWorkDemo.DataAccess.Abstact;
using EntityFrameWorkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.Business
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
