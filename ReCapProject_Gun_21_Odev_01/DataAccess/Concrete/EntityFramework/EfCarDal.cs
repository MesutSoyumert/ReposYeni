using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars

                             join color in context.Colors
                             on car.ColorId equals color.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             select new CarDetailDto()
                             {
                                 Id = car.Id,
                                 ColorId = color.Id,
                                 ColorName = color.Name,
                                 BrandId = brand.Id,
                                 BrandName = brand.Name,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 IsRented = car.IsRented,
                                 MinFindexScore = car.MinFindexScore
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public CarDetailDto GetCarDetails(int carId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars.Where(c => c.Id == carId)

                             join color in context.Colors
                             on car.ColorId equals color.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             select new CarDetailDto()
                             {
                                 Id = car.Id,
                                 ColorId = color.Id,
                                 ColorName = color.Name,
                                 BrandId = brand.Id,
                                 BrandName = brand.Name,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 IsRented = car.IsRented,
                                 MinFindexScore = car.MinFindexScore
                             };

                return result.SingleOrDefault();
            }
        }
    }
}