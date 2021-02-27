using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = brandManager.Delete(new Brand {BrandName = "Skoda" });
            if (result.Success)
            {
                foreach (var brand in brandManager.GetAll().Data)
                {
                    System.Console.WriteLine(brand.BrandName);
                }
            }
            
        }
    }
}
