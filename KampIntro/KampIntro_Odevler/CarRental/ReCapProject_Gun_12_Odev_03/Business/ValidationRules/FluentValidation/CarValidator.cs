using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.BrandId).GreaterThan(0);
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.ColorId).GreaterThan(0);
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.ModelYear).MinimumLength(4);
            RuleFor(p => p.ModelYear).GreaterThan("2010");
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(2);
        }
    }
}
