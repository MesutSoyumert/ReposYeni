using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             select new CarDetailDto
                             {
                                 Id = p.Id,
                                 BrandId = p.Id,
                                 ColorId = c.Id,
                                 ModelYear = p.ModelYear,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description
                             };
                return result.ToList();
            }
        }
    }
}
