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
           
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental {CarId = 5, CustomerId = 3, RentDate = new DateTime(2021, 2, 22)});

            if (result.Success)
            {
                System.Console.WriteLine(result.Messages);
            }
            else
            {
                System.Console.WriteLine(result.Messages);
            }

        }
    }
}
