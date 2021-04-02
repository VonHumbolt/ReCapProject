using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join color in context.Colors
                             on c.ColorId equals color.ColorId
                             join img in context.CarImages
                             on c.CarId equals img.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColorId = c.ColorId,
                                 BrandId = c.BrandId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 ImagePath = img.ImagePath,
                                 Findeks = c.Findeks
                             };

                return filter == null ?
                    result.ToList() : result.Where(filter).ToList();
            }
        }


        public List<CarImageDetailDto> GetCarImages(int carId)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars where c.CarId == carId
                             join img in context.CarImages
                             on c.CarId equals img.CarId
                             select new CarImageDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 CarImage = img.ImagePath
                             };

                return result.ToList();
            }
        }

    }
}
