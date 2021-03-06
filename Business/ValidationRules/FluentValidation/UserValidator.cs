using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2).WithMessage("İsminiz 2 veya daha fazla harften oluşmalıdır.");
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2).WithMessage("Soyisminiz 2 veya daha fazla harften oluşmalıdır.");
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).Must(ContainEmailSign);

        }

        private bool ContainEmailSign(string arg)
        {
            return arg.Contains("@");
        }
    }
}
