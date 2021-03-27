using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).MinimumLength(6);
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MinimumLength(8);
            //Password için başka validation rules eklenebilir mi diye bak
        }
    }
}
