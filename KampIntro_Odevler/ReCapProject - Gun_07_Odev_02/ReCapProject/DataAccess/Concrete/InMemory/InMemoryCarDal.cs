using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, Description= "Clio Symbol", ModelYear = "2020"},
            new Car{Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 110, Description= "Megan", ModelYear = "2021"},
            new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 120, Description= "Aegea", ModelYear = "2020"},
            new Car{Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 130, Description= "Doblo", ModelYear = "2019"},
            new Car{Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 140, Description= "Jetta", ModelYear = "2017"},
            new Car{Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 170, Description= "Octavia", ModelYear = "2021"},
            new Car{Id = 7, BrandId = 3, ColorId = 4, DailyPrice = 190, Description= "SuperB", ModelYear = "2020"},
            new Car{Id = 8, BrandId = 3, ColorId = 5, DailyPrice = 220, Description= "206", ModelYear = "2015"},
            new Car{Id = 9, BrandId = 4, ColorId = 6, DailyPrice = 250, Description= "3.16", ModelYear = "2018"},
            new Car{Id = 10, BrandId = 5, ColorId = 7, DailyPrice = 300, Description= "200 E", ModelYear = "2019"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Araba eklendi");
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            Console.WriteLine("Araba güncellendi");

        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
            Console.WriteLine("Araba silindi");

        }



        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            Console.WriteLine("Araba listesi hazırlandı");
            return _cars;
        }

        public Car GetById(int id)
        {
            Car carFound = _cars.SingleOrDefault(p => p.Id == id);
            Console.WriteLine("İstenen araba hazırandı");
            return carFound;
        }
    }
}
