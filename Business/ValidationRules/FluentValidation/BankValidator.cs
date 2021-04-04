using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BankValidator : AbstractValidator<UserCardDetail>
    {
        
        public BankValidator()
        {
            RuleFor(u => u.CardNumber).NotEmpty();

            RuleFor(u => u.CardNumber).Length(12);
        }
    }
}
