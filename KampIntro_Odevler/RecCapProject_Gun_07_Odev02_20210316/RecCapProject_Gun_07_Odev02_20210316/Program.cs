using RecCapProject_Gun_07_Odev02_20210316.DataAccess.Concrete.InMemory;
using RecCapProject_Gun_07_Odev02_20210316.Entitites;
using System;

namespace RecCapProject_Gun_07_Odev02_20210316
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            InMemoryCarDal carManagerGetById = new InMemoryCarDal();
            int id = 10;
            inMemoryCarDal.GetById(id);

            InMemoryCarDal carAdd = new InMemoryCarDal();
            carAdd.Add(new Car
            {
                Id = 11,
                BrandId = 8,
                ColorId = 2,
                DailyPrice = 500,
                Description = "Maybach",
                ModelYear = "2021"
            });
            InMemoryCarDal carUpdate = new InMemoryCarDal();
            carUpdate.Update(new Car
            {
                Id = 8,
                BrandId = 7,
                ColorId = 1,
                DailyPrice = 800,
                Description = "Maybach",
                ModelYear = "2021"
            });
            InMemoryCarDal carDelete = new InMemoryCarDal();
            carDelete.Delete(new Car
            {
                Id = 4,
            });

        }
    }
}
