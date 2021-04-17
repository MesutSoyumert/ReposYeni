using Core.Utilities.Results;
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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarMostDetailDto>> GetMostCarDetails();
        IDataResult<List<CarMostDetailDto>> GetMostCarDetailsByBrand(int id);
        IDataResult<List<CarMostDetailDto>> GetMostCarDetailsByColor(int id);
        IDataResult<CarMostDetailDto> GetMostCarDetailsById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
