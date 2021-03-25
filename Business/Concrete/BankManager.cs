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
        private ICardInfoDal _cardInfoDal;

        public BankManager(ICardInfoDal cardInfoDal)
        {
            _cardInfoDal = cardInfoDal;
        }

        public IResult Rent(CardInfo cardInfo)
        {
            _cardInfoDal.Add(cardInfo);
            return new SuccessResult("Ödeme işlemi tamamlandı!");
        }
    }
}
