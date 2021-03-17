using EntityFrameWorkDemo.DataAccess.Abstact;
using EntityFrameWorkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.DataAccess.Concrete
{
    public class EfPersonelDal : IPersonelDal
    {
        public void Add(Personel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Personels.ToList();
            }
        }

        public Personel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}
