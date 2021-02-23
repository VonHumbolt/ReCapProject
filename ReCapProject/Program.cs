using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            carManager.Add(new Car { CarId = 6, BrandId = 1, ColorId = 2, ModelYear = 2009, DailyPrice = 300, Description = "Hafif Hasarlı" });
            carManager.Update(new Car { CarId = 6, BrandId = 3, ColorId = 1, ModelYear = 2010 });
            System.Console.WriteLine(carManager.GetById(6).BrandId);
            
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear);
            }
        }
    }
}
