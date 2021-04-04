using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BankManager : IBankService
    {
        [ValidationAspect(typeof(BankValidator))]
        public IResult Pay(UserCardDetail userCardDetail)
        {
            return new SuccessResult("Ödeme işlemi başarılı!");
        }
    }
}
