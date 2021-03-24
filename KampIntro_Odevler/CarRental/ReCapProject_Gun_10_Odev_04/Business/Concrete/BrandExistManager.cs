using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandExistManager : IBrandExistService
    {
        public bool CheckIfBrandExist(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetById(brand.Id);

            if (result.Success == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
