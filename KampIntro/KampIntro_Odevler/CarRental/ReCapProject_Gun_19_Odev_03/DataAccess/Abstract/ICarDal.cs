using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarMostDetailDto> GetMostCarDetails();
        List<CarMostDetailDto> GetMostCarDetailsByBrand(int id);
        List<CarMostDetailDto> GetMostCarDetailsByColor(int id);
        CarMostDetailDto GetMostCarDetailsById(int id);
    }
}
