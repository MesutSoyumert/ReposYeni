﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aspects.Validation;
using Core.Aspects.Autofac.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IColorService _colorService;
        IBrandService _brandService;
        Random _random;

        public CarManager(ICarDal carDal, IColorService colorService, IBrandService brandService)
        {
            _carDal = carDal;
            _colorService = colorService;
            _brandService = brandService;
            _random = new Random();
        }

        //[SecuredOperation("car.add,car.admin,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        //[PerformanceAspect(10)]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfBrandExists(car.BrandId),
                                               CheckIfColorExists(car.ColorId));
            if (result != null)
            {
                return result;
            }
            car.MinFindexScore = _random.Next(0, 1900);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        //[SecuredOperation("car.delete,car.admin,admin")]
        [CacheRemoveAspect("ICarService.Get")]
        //[PerformanceAspect(10)]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        //[SecuredOperation("car.update,car.admin,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        //[PerformanceAspect(10)]
        public IResult Update(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfBrandExists(car.BrandId),
                                               CheckIfColorExists(car.ColorId));
            if (result != null)
            {
                return result;
            }
            car.MinFindexScore = _random.Next(0, 1900);
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        //[SecuredOperation("car.list.getall,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 03)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        //[SecuredOperation("car.list.getbyid,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id), Messages.CarFound);
        }

        //[SecuredOperation("car.list.getcardetails,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<CarDetailDto> GetCarDetails(int carId)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarDetails(carId));
        }

        //[SecuredOperation("car.list.getcarsbybrandid,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<CarDetailDto>> GetByBrand(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails(c => c.BrandId == brandId));
        }

        //[SecuredOperation("car.list.getcarsbycolorid,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<CarDetailDto>> GetByColor(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails(c => c.ColorId == colorId));
        }

        //[SecuredOperation("car.list.getcarswithdetails,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<CarDetailDto>> GetCarsWithDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails());
        }

        //[SecuredOperation("car.list.getcarsbybrandandcolor,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<CarDetailDto>> GetCarsByBrandAndColor(int brandId, int colorId)
        {
            List<CarDetailDto> car = (_carDal.GetCarsDetails(c => c.BrandId == brandId && c.ColorId == colorId));

            if (car == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.CarsMostDetailsByColorAndByBrandNotFound);
            }

            return new SuccessDataResult<List<CarDetailDto>>(car, Messages.CarsMostDetailsByColorAndByBrandListed);
        }

        //[SecuredOperation("car.list.getcarsbydailyprice,car.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
            }
        }
        private IResult CheckIfBrandExists(int BrandId)
        {
            var result = _brandService.GetById(BrandId);
            if (result.Success == false || result.Data == null)
            {
                return new ErrorResult(Messages.BrandNotFound);
            }
            return new SuccessResult();
        }

        private IResult CheckIfColorExists(int ColorId)
        {
            var result = _colorService.GetById(ColorId);
            if (result.Success == false || result.Data == null)
            {
                return new ErrorResult(Messages.ColorNotFound);
            }
            return new SuccessResult();
        }
    }
}