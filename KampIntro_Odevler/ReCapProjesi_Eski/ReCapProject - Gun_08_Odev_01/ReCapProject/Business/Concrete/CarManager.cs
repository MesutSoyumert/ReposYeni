using ReCapProject.Business.Abstract;
using ReCapProject.Business.ValidationRules.FluentValidation;
using ReCapProject.Core.Aspects.Autofac.Validation;
using ReCapProject.Core.Utilities.Business;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;
        IColorService _colorService;
        public CarManager(ICarDal carDal, IBrandService brandService, IColorService colorService)
        {
            _carDal = carDal;
            _brandService = brandService;
            _colorService = colorService;
        }

        [ValidationAspect(typeof(CarValidator))]

        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName),
                CheckIfProductCountOfCategoryCorrect(product.CategoryId), CheckIfCategoryLimitExceded());

            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.ProductAdded);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _carDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
