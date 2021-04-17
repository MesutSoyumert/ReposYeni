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
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join l in context.Colors on c.ColorId equals l.Id

                             select new CarDetailDto
                             {
                                 CarName = c.Description,
                                 BrandName = b.Name,
                                 ColorName = l.Name,
                                 DailyPrice = c.DailyPrice,
                                 IsRented = c.IsRented
                             };
                return result.ToList();
            }
        }

        public List<CarMostDetailDto> GetMostCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join l in context.Colors on c.ColorId equals l.Id

                             select new CarMostDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.Name,
                                 ColorName = l.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,
                                 IsRented = c.IsRented
                             };
                return result.ToList();
            }
        }

        public List<CarMostDetailDto> GetMostCarDetailsByBrand(int brandId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join l in context.Colors on c.ColorId equals l.Id
                             where c.BrandId == brandId

                             select new CarMostDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.Name,
                                 ColorName = l.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,
                                 IsRented = c.IsRented
                             };
                return result.ToList();
            }
        }

        public List<CarMostDetailDto> GetMostCarDetailsByColor(int colorId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join l in context.Colors on c.ColorId equals l.Id
                             where c.ColorId == colorId

                             select new CarMostDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.Name,
                                 ColorName = l.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,
                                 IsRented = c.IsRented
                             };
                return result.ToList();
            }
        }
        public CarMostDetailDto GetMostCarDetailsById(int carId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars.Where(c => c.Id == carId)
                             join b in context.Brands on c.BrandId equals b.Id
                             join l in context.Colors on c.ColorId equals l.Id


                             select new CarMostDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.Name,
                                 ColorName = l.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.Description,
                                 IsRented = c.IsRented
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
