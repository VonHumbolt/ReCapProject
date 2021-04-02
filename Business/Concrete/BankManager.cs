using Business.Abstract;
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
        // Credit card valid mi !
        public IResult Pay()
        {
            return new SuccessResult("Ödeme işlemi başarılı!");
        }
    }
}
