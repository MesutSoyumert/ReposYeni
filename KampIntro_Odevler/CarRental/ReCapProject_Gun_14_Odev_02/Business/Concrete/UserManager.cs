using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aspects.Validation;
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
        [ValidationAspect(typeof(UserValidator))]
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

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == id), Messages.UserFound);
        }

        [ValidationAspect(typeof(UserValidator))]
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