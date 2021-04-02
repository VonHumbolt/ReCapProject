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
    }
}
