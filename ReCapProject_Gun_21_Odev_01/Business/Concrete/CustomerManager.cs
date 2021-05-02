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
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        Random _random;

        //IUserService _userService;
        //IRentalService _rentalService;
        //public CustomerManager(ICustomerDal customerDal, IUserService userService, IRentalService rentalService)
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
            _random = new Random();
            //_userService = userService;
            //_rentalService = rentalService;
        }

        //[SecuredOperation("customer.add,customer.admin,admin")]
        [ValidationAspect(typeof(CustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        //[PerformanceAspect(10)]
        public IResult Add(Customer customer)
        {
            //IResult result = BusinessRules.Run(CheckIfCustomerCompanyNameExists(customer.CompanyName),
            //                       CheckIfUserIdExists(customer.UserId),
            //                       CheckIfCustomerUserIdExists(customer.UserId));

            IResult result = BusinessRules.Run(CheckIfCustomerCompanyNameExists(customer.CompanyName),
                                               CheckIfCustomerUserIdExists(customer.UserId));
            if (result != null)
            {
                return result;
            }
            customer.FindexScore = _random.Next(0, 1900);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        //[SecuredOperation("customer.delete,customer.admin,admin")]
        [CacheRemoveAspect("ICustomerService.Get")]
        //[PerformanceAspect(10)]
        public IResult Delete(Customer customer)
        {
            //IResult result = BusinessRules.Run(CheckIfCustomerHasActiveRentalExists(customer.Id));
            //if (result != null)
            //{
            //    return result;
            //}
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        //[SecuredOperation("customer.update,customer.admin,admin")]
        [ValidationAspect(typeof(CustomerValidator))]
        [CacheRemoveAspect("ICustomerService.Get")]
        //[PerformanceAspect(10)]
        public IResult Update(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfCustomerCompanyNameExists(customer.CompanyName),
                                               CheckIfCustomerUserIdExists(customer.UserId));
            if (result != null)
            {
                return result;
            }
            customer.FindexScore = _random.Next(0, 1900);
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        //[SecuredOperation("customer.list.getall,customer.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Customer>> GetCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        //[SecuredOperation("customer.list.getbyid,customer.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Id == id), Messages.CustomerFound);
        }

        //[SecuredOperation("customer.list.getcustomersbyuserid,customer.admin,admin")]
        [CacheRemoveAspect("ICustomerService.Get")]
        //[PerformanceAspect(10)]
        public IDataResult<List<Customer>> GetCustomersByUserId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.UserId == id), Messages.CarsByBrandIdListed);
        }

        //[SecuredOperation("customer.list.getcustomersbyuserid,customer.admin,admin")]
        [CacheRemoveAspect("ICustomerService.Get")]
        //[PerformanceAspect(10)]
        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto());
        }

        //[SecuredOperation("customer.list.getcustomersbyuserid,customer.admin,admin")]
        [CacheRemoveAspect("ICustomerService.Get")]
        //[PerformanceAspect(10)]
        public IDataResult<List<CustomerDetailDto>> GetCustomerDetailByUserId(int userId)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto(u => u.UserId == userId));
        }
        
        private IResult CheckIfCustomerCompanyNameExists(string CompanyName)
        {
            var result = _customerDal.GetAll(p => p.CompanyName == CompanyName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CustomerCompanyNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCustomerUserIdExists(int UserId)
        {
            var result = _customerDal.GetAll(p => p.UserId == UserId).Any();
            if (result)
            {
                return new ErrorResult(Messages.CustomerUserIdAlreadyExists);
            }
            return new SuccessResult();
        }
        //private IResult CheckIfUserIdExists(int UserId)
        //{
        //    var result = _userService.GetById(UserId);

        //    if (result.Success == false || result.Data == null)
        //    {
        //        return new ErrorResult(Messages.UserNotFound);
        //    }
        //    return new SuccessResult();
        //}
        //private IResult CheckIfCustomerHasActiveRentalExists(int id)
        //{
        //    var result = _rentalService.GetRentalsByCustomerId(id);

        //    if (result.Data.Count > 0)
        //    {
        //        return new ErrorResult(Messages.CustomerHasActiveRentalExists);
        //    }
        //    return new SuccessResult();
        //}
    }
}
