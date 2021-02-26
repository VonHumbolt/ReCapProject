using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarName = "Focus", DailyPrice = 240, BrandId = 2, ColorId = 5, Description = "Hasarsız", ModelYear = 2010 });

            foreach (var car in carManager.GetCarsByColorId(5))
            {
                System.Console.WriteLine(car.DailyPrice);
            } 
        }
    }
}
