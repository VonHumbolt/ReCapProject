using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,CarDatabaseContext>, ICustomerDal
    {
        public List<RegisteredCustomerDto> GetRegisteredCustomerDtos()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new RegisteredCustomerDto
                             {
                                 CompanyName = c.CompanyName,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Findeks = c.Findeks
                             };

                return result.ToList();
            }
        }

        public RegisteredCustomerDto GetRegisteredCustomerDtoByEmail(string email)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from user in context.Users
                             where user.Email == email
                             join customer in context.Customers
                             on user.Id equals customer.UserId
                             select new RegisteredCustomerDto
                             {
                                 CompanyName = customer.CompanyName,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Findeks = customer.Findeks
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
