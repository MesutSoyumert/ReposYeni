using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aspects.Validation;
using Core.Aspects.Autofac.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarService _carService;
        ICustomerService _customerService;
        public RentalManager(IRentalDal rentalDal, ICarService carService, ICustomerService customerService)
        {
            _rentalDal = rentalDal;
            _carService = carService;
            _customerService = customerService;
        }

        [SecuredOperation("rental.add,rental.admin,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        //[PerformanceAspect(10)]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckIfCarExists(rental.CarId),
                                               CheckIfRentalCarIsAlreadyRented(rental.CarId),
                                               CheckIfCustomerExists(rental.CustomerId));
            if (result != null)
            {
                return result;
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        [SecuredOperation("rental.delete,rental.admin,admin")]
        [CacheRemoveAspect("IRentalService.Get")]
        //[PerformanceAspect(10)]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        [SecuredOperation("rental.update,rental.admin,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        //[PerformanceAspect(10)]
        public IResult Update(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckIfCarExists(rental.CarId),
                                               CheckIfRentalCarIsAlreadyRented(rental.CarId),
                                               CheckIfCustomerExists(rental.CustomerId));
            if (result != null)
            {
                return result;
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        [SecuredOperation("rental.list.getall,rental.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        [SecuredOperation("rental.list.getbyid,rental.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id), Messages.RentalFound);
        }

        [SecuredOperation("rental.list.getrentalsbycustomerid,rental.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Rental>> GetRentalsByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CustomerId == id && p.ReturnDate == new DateTime(0001, 01, 01, 0, 0, 0)), Messages.RentalsByCutomerIdListed);
        }

        private IResult CheckIfCarExists(int CarId)
        {
            var result = _carService.GetById(CarId);

            if (result.Success == false || result.Data == null)
            {
                return new ErrorResult(Messages.CarNotFound);
            }
            return new SuccessResult();
        }
        private IResult CheckIfRentalCarIsAlreadyRented(int CarId)
        {
            var result = _carService.GetById(CarId);

            if (result.Success == false || result.Data == null)
            {
                return new ErrorResult(Messages.CarNotFound);
            }
            if (result.Data.IsRented == true)
            {
                return new ErrorResult(Messages.RentalCarIsAlreadyRented);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCustomerExists(int CustomerId)
        {
            var result = _customerService.GetById(CustomerId);

            if (result.Success == false || result.Data == null)
            {
                return new ErrorResult(Messages.CarNotFound);
            }
            return new SuccessResult();
        }
    }
}
