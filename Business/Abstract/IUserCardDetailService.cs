using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserCardDetailService
    {
        IDataResult<UserCardDetail> GetCarDetailByUserId(int userId);

        IResult Add(UserCardDetail userCardDetail);
    }
}
