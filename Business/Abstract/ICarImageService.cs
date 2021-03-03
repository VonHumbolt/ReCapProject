using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage image, IFormFile formFile);

        IResult Delete(CarImage image);

        IResult Update(IFormFile formFile, CarImage image);

        IDataResult<List<CarImage>> GetCarImageByCarId(int carId);

    }
}
