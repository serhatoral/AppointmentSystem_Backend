using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(u=>u.UserName).MinimumLength(2);
            RuleFor(u => u.UserName).MaximumLength(50);

            RuleFor(u => u.UserSurname).NotEmpty();
            RuleFor(u => u.UserSurname).MinimumLength(2);
            RuleFor(u => u.UserSurname).MaximumLength(50);

            RuleFor(u => u.UserAge).NotEmpty();
            RuleFor(u => u.UserAge).GreaterThanOrEqualTo(18);
            RuleFor(u => u.UserAge).LessThanOrEqualTo(90);

            RuleFor(u => u.UserEmail).NotEmpty();
            RuleFor(u => u.UserEmail).EmailAddress();

            RuleFor(u => u.Password).MinimumLength(6);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MaximumLength(50);
        }
    }
}
