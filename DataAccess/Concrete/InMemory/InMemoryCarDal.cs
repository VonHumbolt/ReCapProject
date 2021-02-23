using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;

        public InMemoryCarDal()
        {
            _carList = new List<Car>
            {
                new Car{CarId = 1, BrandId = 2, ColorId = 3, DailyPrice = 102, Description = "Hasarsız", ModelYear = 2005},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 202, Description = "Kazalı", ModelYear = 2007},
                new Car{CarId = 3, BrandId = 4, ColorId = 2, DailyPrice = 311, Description = "Kazalı", ModelYear = 2008},
                new Car{CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = 422, Description = "Hasarsız", ModelYear = 2011},

            };
        }
        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            var result = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            _carList.Remove(result);
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public Car GetById(int carId)
        {
            return _carList.SingleOrDefault(c => c.CarId == carId);
        }

        public void Update(Car car)
        {
            var result = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            result.BrandId = car.BrandId;
            result.ColorId = car.ColorId;
            result.DailyPrice = car.DailyPrice;
            result.Description = car.Description;
            result.ModelYear = car.ModelYear;
        }
    }
}
