using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
           
            _customerDal.Add(customer);

            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.GetById(c => c.Id == customerId));
        }

        public IDataResult<Customer> GetCustomerByUserId(int userId)
        {
            return new SuccessDataResult<Customer>(_customerDal.GetById(c => c.UserId == userId));
        }

        public IDataResult<RegisteredCustomerDto> GetRegisteredCustomerDtoByEmail(string email)
        {
            return new SuccessDataResult<RegisteredCustomerDto>(_customerDal.GetRegisteredCustomerDtoByEmail(email));
        }

        public IDataResult<List<RegisteredCustomerDto>> GetRegisteredCustomerDtos()
        {
            return new SuccessDataResult<List<RegisteredCustomerDto>>(_customerDal.GetRegisteredCustomerDtos());
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);

            return new SuccessResult();
        }
    }
}
