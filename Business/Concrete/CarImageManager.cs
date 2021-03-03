using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage image, IFormFile formFile)
        {
            var result = BusinessRules.Run(CheckIfImageCountIsCorrect(image.CarId));

            if (result != null)
            {
                return result;
            }
            
            image.ImagePath = FileHelper.Add(formFile);
            image.Date = DateTime.Now;

            _carImageDal.Add(image);

            return new SuccessResult();
        
        }

        public IResult Delete(CarImage image)
        {
            var result = _carImageDal.GetById(c => c.Id == image.Id).ImagePath;

            FileHelper.Delete(result);
            _carImageDal.Delete(image);

            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetCarImageByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        public IResult Update(IFormFile formFile, CarImage image)
        {
            string oldPath = _carImageDal.GetById(c => c.Id == image.Id).ImagePath;

            image.ImagePath = FileHelper.Update(oldPath, formFile);
            image.Date = DateTime.Now;
            _carImageDal.Update(image);

            return new SuccessResult();
        }

        private IResult CheckIfImageCountIsCorrect(int carId)
        {
            if (_carImageDal.GetAll(c=>c.CarId == carId).Count >= 5)
            {
                return new ErrorResult(Message.CarImageCountIsFull);
            }
            return new SuccessResult();
        }
    }
}
