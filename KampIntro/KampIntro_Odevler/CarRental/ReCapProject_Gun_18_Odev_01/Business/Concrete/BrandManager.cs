using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Aspects.Validation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [SecuredOperation("brand.add,brand.admin,admin")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        //[PerformanceAspect(10)]
        public IResult Add(Brand brand)
        {
            IResult result = BusinessRules.Run(CheckIfBrandNameExists(brand.Name));
            if (result != null)
            {
                return result;
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        [SecuredOperation("brand.delete,brand.admin,admin")]
        [CacheRemoveAspect("IBrandService.Get")]
        //[PerformanceAspect(10)]
        public IResult Delete(Brand brand)
        {
            IResult result = BusinessRules.Run(CheckIfBrandToDeleteCarsHasBrand(brand.Id));
            if (result != null)
            {
                return result;
            }
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        //[SecuredOperation("brand.list.getall,brand.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        [SecuredOperation("brand.list.getbyid,brand.admin,admin")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == id), Messages.BrandFound);
        }

        [SecuredOperation("brand.delete,brand.admin,admin")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        //[PerformanceAspect(10)]
        public IResult Update(Brand brand)
        {
            IResult result = BusinessRules.Run(CheckIfBrandNameExists(brand.Name));
            if (result != null)
            {
                return result;
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
        private IResult CheckIfBrandNameExists(string Name)
        {
            var result = _brandDal.GetAll(p => p.Name == Name).Any();
            if (result)
            {
                return new ErrorResult(Messages.BrandNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfBrandToDeleteCarsHasBrand(int id)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarsByBrandId(id);

            //if (result != null && result.Data.Count > 0)
            //{
            //    return new ErrorResult(Messages.BrandToDeleteCarsHasBrand);
            //}
            return new SuccessResult();
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Brand brand)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    Add(brand);
                    if (brand.Name.Length < 2)
                    {
                        throw new Exception("Eklenen brandı geri al");
                    }
                    Add(brand);
                    scope.Complete();
                }
                catch (Exception)
                {

                    scope.Dispose();
                }
            }
            throw new NotImplementedException();
        }
    }
}