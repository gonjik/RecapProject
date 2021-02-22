using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
            RuleFor(u => u.Password).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir harf içermelidir.");
            RuleFor(u => u.Password).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir sayı içermelidir.");
        }

    }
}
