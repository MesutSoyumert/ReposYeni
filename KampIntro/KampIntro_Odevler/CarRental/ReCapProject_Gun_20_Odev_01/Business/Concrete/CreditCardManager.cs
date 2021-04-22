using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
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
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }
        //[SecuredOperation("creditcard.add,creditcard.admin,admin")]
        //[PerformanceAspect(10)]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Add(CreditCard creditCard)
        {
            IResult result = BusinessRules.Run(IsCardExist(creditCard));

            if (result != null)
            {
                return result;
            }
            _creditCardDal.Add(creditCard);
            return new SuccessResult();
        }

        //[SecuredOperation("creditcard.add,creditcard.admin,admin")]
        //[PerformanceAspect(10)]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult();
        }

        //[SecuredOperation("creditcard.add,creditcard.admin,admin")]
        //[PerformanceAspect(10)]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult();
        }

        //[SecuredOperation("creditcard.add,creditcard.admin,admin")]
        //[PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        }

        //[SecuredOperation("creditcard.add,creditcard.admin,admin")]
        //[PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<CreditCard>> GetByCustomer(int id)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CustomerId == id));
        }
        private IResult IsCardExist(CreditCard creditCard)
        {
            var result = _creditCardDal.Get(c =>
            c.NameOnTheCard == creditCard.NameOnTheCard
            && c.CardNumber == creditCard.CardNumber
            && c.CVV == creditCard.CVV
            && c.ExpirationDate == creditCard.ExpirationDate);

            if (result != null)
            {
                return new ErrorResult(Messages.CardExist);
            }

            return new SuccessResult();
        }
    }
}