using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            var result = carManager.GetById(1);
            Console.WriteLine(" GetById Bulunan =");
            Console.WriteLine(result.Id + "/" +
                    result.ColorId + "/" +
                    result.BrandId + "/" +
                    result.DailyPrice + "/" +
                    result.Description + "/" +
                    result.ModelYear);
            Console.WriteLine("GetById Bulunan sonu");

            Console.WriteLine(" GetAll Bulunan =");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" GetAll Bulunan sonu");


            Console.WriteLine(" GetCarsByBrandId Bulunan =");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" GetCarsByBrandId Bulunan sonu");

            Console.WriteLine(" GetCarsByColorId Bulunan =");
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" GetCarsByColorId Bulunan sonu");
        }
    }
}
