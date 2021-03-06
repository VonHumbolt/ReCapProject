﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserCardDetailManager : IUserCardDetailService
    {
        IUserCardDetailDal _userCardDetailDal;

        public UserCardDetailManager(IUserCardDetailDal userCardDetailDal)
        {
            _userCardDetailDal = userCardDetailDal;
        }

        public IResult Update(UserCardDetail userCardDetail)
        {
            _userCardDetailDal.Update(userCardDetail);
            return new SuccessResult("Kart Bilgileri kaydedildi");
        }

        public IDataResult<UserCardDetail> GetCarDetailByUserId(int userId)
        {
            return new SuccessDataResult<UserCardDetail>(_userCardDetailDal.GetById(u => u.Id == userId));
        }
    }
}
