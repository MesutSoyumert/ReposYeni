using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        Car GetById(int id);
        List<CarDetailDto> GetCarDetails();

        //Car Add(Car car);
        //Car Update(Car car);
        //Car Delete(Car car);

    }
}
