using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalsDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rental in context.Rentals

                             join car in context.Cars
                             on rental.Id equals car.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id

                             join user in context.Users
                             on customer.UserId equals user.Id

                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarID = car.Id,
                                 BrandName = brand.Name,
                                 UserName = user.FirstName + " " + user.LastName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }
        }
        public RentalDetailDto GetRentalDetails(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rental in context.Rentals.Where(r => r.Id == id)

                             join car in context.Cars
                                 on rental.CarId equals car.Id

                             join brand in context.Brands
                                 on rental.BrandId equals brand.Id

                             join customer in context.Customers
                        on rental.CustomerId equals customer.Id

                             join user in context.Users
                                 on customer.UserId equals user.Id

                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarID = car.Id,
                                 BrandName = brand.Name,
                                 UserName = user.FirstName + " " + user.LastName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
