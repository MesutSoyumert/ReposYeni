﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aspects.Validation;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        //IUserService _userService;
        //IRentalService _rentalService;
        //public CustomerManager(ICustomerDal customerDal, IUserService userService, IRentalService rentalService)
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
            //_userService = userService;
            //_rentalService = rentalService;
        }

        [ValidationAspect(typeof(CustomerValidator))]
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
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

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

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Id == id), Messages.CustomerFound);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Update(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfCustomerCompanyNameExists(customer.CompanyName),
                                               CheckIfCustomerUserIdExists(customer.UserId));
            if (result != null)
            {
                return result;
            }
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
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
        
        public IDataResult<List<Customer>> GetCustomersByUserId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.UserId == id), Messages.CarsByBrandIdListed);
        }
    }
}