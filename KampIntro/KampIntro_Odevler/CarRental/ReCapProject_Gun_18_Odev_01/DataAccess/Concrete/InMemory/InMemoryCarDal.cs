using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "Clio Symbol", ModelYear = "2020" },
                new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 110, Description = "Megan", ModelYear = "2021" },
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 120, Description = "Aegea", ModelYear = "2020" },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 130, Description = "Doblo", ModelYear = "2019" },
                new Car { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 140, Description = "Jetta", ModelYear = "2017" },
                new Car { Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 170, Description = "Octavia", ModelYear = "2021" },
                new Car { Id = 7, BrandId = 3, ColorId = 4, DailyPrice = 190, Description = "SuperB", ModelYear = "2020" },
                new Car { Id = 8, BrandId = 3, ColorId = 5, DailyPrice = 220, Description = "206", ModelYear = "2015" },
                new Car { Id = 9, BrandId = 4, ColorId = 6, DailyPrice = 250, Description = "3.16", ModelYear = "2018" },
                new Car { Id = 10, BrandId = 5, ColorId = 7, DailyPrice = 300, Description = "200 E", ModelYear = "2019" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarMostDetailDto> GetMostCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
