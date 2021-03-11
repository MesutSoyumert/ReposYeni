using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarRentalContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from p in context.Brands
                             join c in context.Cars
                             on p.Id equals c.BrandId
                             select new BrandDetailDto
                             {
                                 Id = p.Id,
                                 Name = p.Name
                             };
                return result.ToList();
            }
        }
    }
}
