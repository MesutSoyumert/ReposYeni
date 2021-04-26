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
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        //[SecuredOperation("admin,color.admin,color.add")]
        [ValidationAspect(typeof(ColorValidator))]
        [CacheRemoveAspect("IColorService.Get")]
        //[PerformanceAspect(10)]
        public IResult Add(Color color)
        {
            IResult result = BusinessRules.Run(CheckIfColorNameExists(color.Name));
            if (result != null)
            {
                return result;
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        //[SecuredOperation("admin,color.admin,color.delete")]
        [CacheRemoveAspect("IColorService.Get")]
        //[PerformanceAspect(10)]
        public IResult Delete(Color color)
        {
            IResult result = BusinessRules.Run(CheckIfColorToDeleteCarsHasColor(color.Id));
            if (result != null)
            {
                return result;
            }
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        //[SecuredOperation("admin,color.admin,color.list.getall")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);

        }

        //[SecuredOperation("admin,color.admin,color.list.getbyid")]
        [CacheAspect]
        //[PerformanceAspect(10)]
        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.Id == id), Messages.ColorFound);

        }

        //[SecuredOperation("admin,color.admin,color.update")]
        [ValidationAspect(typeof(ColorValidator))]
        [CacheRemoveAspect("IColorService.Get")]
        //[PerformanceAspect(10)]
        public IResult Update(Color color)
        {
            IResult result = BusinessRules.Run(CheckIfColorNameExists(color.Name));
            if (result != null)
            {
                return result;
            }
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
        private IResult CheckIfColorNameExists(string Name)
        {
            var result = _colorDal.GetAll(p => p.Name == Name).Any();
            if (result)
            {
                return new ErrorResult(Messages.ColorNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfColorToDeleteCarsHasColor(int id)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarsByBrandId(id);

            //if (result != null && result.Data.Count > 0)
            //{
            //    return new ErrorResult(Messages.ColorToDeleteCarsHasColor);
            //}
            return new SuccessResult();
        }
    }
}
