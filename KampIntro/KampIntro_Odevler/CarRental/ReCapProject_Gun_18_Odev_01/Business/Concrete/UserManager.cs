using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aspects.Validation;
using Core.Aspects.Autofac.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concrete;
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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        //ICustomerService _customerService;
        //public UserManager(IUserDal userDal, ICustomerService customerService)

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
            //_customerService = customerService;
        }

        [SecuredOperation("user.add,user.admin,admin")]
        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        //[PerformanceAspect(10)]
        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(CheckIfUserCredentialsExists(user.FirstName, user.LastName, user.Email));
            if (result != null)
            {
                return result;
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        [SecuredOperation("user.delete,user.admin,admin")]
        [CacheRemoveAspect("IUserService.Get")]
        //[PerformanceAspect(10)]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        [SecuredOperation("user.update,user.admin,admin")]
        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        //[PerformanceAspect(10)]
        public IResult Update(User user)
        {
            IResult result = BusinessRules.Run(CheckIfUserCredentialsExists(user.FirstName, user.LastName, user.Email));
            if (result != null)
            {
                return result;
            }
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        //[SecuredOperation("user.list.getall,user.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        [SecuredOperation("user.list.getbyid,user.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == id), Messages.UserFound);
        }

        //[SecuredOperation("user.list.getclaims, user.admin, admin")]// Bunu düşün
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
        
        //[SecuredOperation("user.list.getbymail, user.admin, admin")]// Bunu düşün
        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
        private IResult CheckIfUserCredentialsExists(string FirstName, string LastName, string Email)
        {
            var result = _userDal.GetAll(p => p.FirstName == FirstName && p.LastName == LastName && p.Email == Email).Any();
            if (result)
            {
                return new ErrorResult(Messages.UserCredentialsExists);
            }
            return new SuccessResult();
        }
        //private IResult CheckIfUserHasActiveCustomerExists(int id)
        //{
        //    var result = _customerService.GetCustomersByUserId(id);

        //    if (result.Data.Count > 0)
        //    {
        //        return new ErrorResult(Messages.UserHasActiveCustomerExists);
        //    }
        //    return new SuccessResult();
        //}
    }
}