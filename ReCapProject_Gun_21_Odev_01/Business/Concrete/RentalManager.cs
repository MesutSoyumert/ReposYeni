using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Business;
using Core.Aspects.Aspects.Validation;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarDal _carDal;
        ICustomerDal _customerDal;

        public RentalManager(IRentalDal rentalDal, ICarDal carDal, ICustomerDal customerDal)
        {
            _rentalDal = rentalDal;
            _carDal = carDal;
            _customerDal = customerDal;
        }

        [CacheRemoveAspect("IRentalService.Get")]
        [SecuredOperation("rental.add,admin,user")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = BusinessRules.Run(CheckCarAvailable(rental),
                CheckFindexScoreByCustomer(rental.CustomerId, rental.CarId));

            if (result != null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        [CacheRemoveAspect("IRentalService.Get")]
        [SecuredOperation("rental.delete,admin")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        [CacheRemoveAspect("IRentalService.Get")]
        [SecuredOperation("rental.update,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        [CacheAspect]
        public IDataResult<List<RentalDetailDto>> GetRentalsDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalsDetails());
        }

        [CacheAspect]
        public IDataResult<RentalDetailDto> GetRentalDetailsById(int id)
        {
            return new SuccessDataResult<RentalDetailDto>(_rentalDal.GetRentalDetails(id));
        }

        private IResult CheckCarAvailable(Rental rental)
        {
            var result =
                _rentalDal.Get(r => (r.CarId == rental.CarId && r.ReturnDate == null)
            || (r.RentDate >= rental.RentDate && r.ReturnDate >= rental.RentDate));

            if (result != null)
            {
                return new ErrorResult(Messages.RentalCarNotAvailable);
            }

            return new SuccessResult();
        }

        private IResult CheckFindexScoreByCustomer(int customerId, int carId)
        {
            var car = _carDal.Get(c => c.Id == carId);

            var customer = _customerDal.Get(c => c.Id == customerId);

            var carScore = car.MinFindexScore;
            var customerScore = customer.FindexScore;

            if (customerScore >= carScore)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.RentalNotEnoughFindexScore);

        }

    }
}