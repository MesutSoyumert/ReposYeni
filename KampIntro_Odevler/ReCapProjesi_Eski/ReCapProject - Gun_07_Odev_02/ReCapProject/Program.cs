using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            
            
            CarManager carManagerGetById = new CarManager(new InMemoryCarDal());
            int id = 1;
            carManager.GetById(id);
            
            
            InMemoryCarDal carAdd = new InMemoryCarDal();
            carAdd.Add(new Entities.Car
            {
                Id = 11,
                BrandId = 8,
                ColorId = 2,
                DailyPrice = 500,
                Description = "Maybach",
                ModelYear = "2021"
            });
            InMemoryCarDal carUpdate = new InMemoryCarDal();
            carUpdate.Update(new Entities.Car
            {
                Id = 8,
                BrandId = 7,
                ColorId = 1,
                DailyPrice = 800,
                Description = "Maybach",
                ModelYear = "2021"
            });
            InMemoryCarDal carDelete = new InMemoryCarDal();
            carDelete.Delete(new Entities.Car
            {
                Id = 4,
            });

        }
    }
}
