using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<CarDetailDto>> GetCarDetailDtos();

        IDataResult<List<CarDetailDto>> GetCarDetailByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailByBrandId(int brandId);

        IDataResult<List<CarDetailDto>> GetCarDetailByCarId(int carId);

        IDataResult<List<CarDetailDto>> FilterCarDetailByColorAndBrandId(int colorId, int brandId);

        IDataResult<List<CarImageDetailDto>> GetCarImages(int carId); 

        IResult AddTransactionalTest(Car car);
    }
}
