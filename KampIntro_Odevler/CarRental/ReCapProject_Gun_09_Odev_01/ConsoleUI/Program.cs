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

            ColorTest();

            BrandTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetById(1);
            Console.WriteLine(" Color GetById Bulunan =");
            Console.WriteLine(result.Id + "/" +
                    result.Name);
            Console.WriteLine("Color GetById Bulunan sonu");

            Console.WriteLine(" Color GetAll Bulunan =");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id + "/" +
                    color.Name);
            }
            Console.WriteLine(" Color GetAll Bulunan sonu");
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(1);
            Console.WriteLine(" Brand GetById Bulunan =");
            Console.WriteLine(result.Id + "/" +
                    result.Name);
            Console.WriteLine("Brand GetById Bulunan sonu");

            Console.WriteLine(" Brand GetAll Bulunan =");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Id + "/" +
                    brand.Name);
            }
            Console.WriteLine(" Brand GetAll Bulunan sonu");
        }


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetById(1);

            Console.WriteLine(" Car GetById Bulunan =");
            Console.WriteLine(result.Id + "/" +
                    result.ColorId + "/" +
                    result.BrandId + "/" +
                    result.DailyPrice + "/" +
                    result.Description + "/" +
                    result.ModelYear);
            Console.WriteLine("Car GetById Bulunan sonu");

            Console.WriteLine(" Car GetAll Bulunan =");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" Car GetAll Bulunan sonu");


            Console.WriteLine(" Car GetCarsByBrandId Bulunan =");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" Car GetCarsByBrandId Bulunan sonu");

            Console.WriteLine(" Car GetCarsByColorId Bulunan =");
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" Car GetCarsByColorId Bulunan sonu");

            Console.WriteLine(" Car GetCarDetails Bulunan =");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" +
                    car.BrandName + "/" +
                    car.ColorName + "/" +
                    car.DailyPrice);
            }
            Console.WriteLine(" Car GetCarDetails Bulunan sonu");
        }
    }
}
