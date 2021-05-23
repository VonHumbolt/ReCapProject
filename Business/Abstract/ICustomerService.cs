﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetCustomerById(int customerId);

        IDataResult<Customer> GetCustomerByUserId(int userId);

        IDataResult<List<RegisteredCustomerDto>> GetRegisteredCustomerDtos();

        IDataResult<RegisteredCustomerDto> GetRegisteredCustomerDtoByEmail(string email);
    }
}
