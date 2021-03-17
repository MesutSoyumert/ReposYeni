using ReCapProject_Gun_08_Odev_01.Business.Abstract;
using ReCapProject_Gun_08_Odev_01.DataAccess.Abstract;
using ReCapProject_Gun_08_Odev_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject_Gun_08_Odev_01.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _iBrandService;
        IColorService _iColorService;

        public CarManager(ICarDal carDal, IBrandService iBrandService, IColorService iColorService)
        {
            _carDal = carDal;
            _iColorService = iColorService;
            _iBrandService = iBrandService;
        }
        public void Add(Car car)
        {

            if (car.Description.Length < 3 )
            {
                Console.WriteLine("Araç adı en az iki karakter olmalıdır");
            }
            else if (car.DailyPrice < 1)
            {
                Console.WriteLine("Araç günlük ücreti sıfırdan büyük olmalıdır");
            }
            else _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
