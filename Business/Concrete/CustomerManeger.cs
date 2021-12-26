using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
namespace Business.Concrete
{
    public class CustomerManeger : ICustomerService
    {
        private ICustomerDal _customerDal;
        private IUserService _userService;

        public CustomerManeger(ICustomerDal customerDal , IUserService userService)
        {
            _customerDal = customerDal;
            _userService = userService;
        }

        public IDataResult<Customer> Add(CustomerDto customerDto )
        {
            var result = CustomerExists(customerDto.Plaka);
            if (result.Data!=null)
            {
                return new ErrorDataResult<Customer>(Messages.CustomerControl);
            }
            var user = _userService.GetByUserKey(customerDto.key);
            var customer = new Customer
            {
                RegisterDate = DateTime.Now,
                Plaka = customerDto.Plaka,
                Brand = customerDto.Brand,
                Year = customerDto.Year,
                Fuel = customerDto.Fuel,
                Name = customerDto.Name,
                Surname = customerDto.Surname,
                Gsm = customerDto.Gsm,
                Note = customerDto.Note,
                UserId = user.Data.Id,
                CompanyId = user.Data.CompanyId,
                Status = true
            };
            _customerDal.Add(customer);

            return new SuccessDataResult<Customer>(customer , Messages.Added);
        }

        public IDataResult<Customer> CustomerExists(string Plaka)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Plaka == Plaka));
        }

        public IDataResult<List<CustomerDto>> CustomerListGetSelectedDate(DateTime StartDate, DateTime EndDate ,int CompanyId)
        {
            return new SuccessDataResult<List<CustomerDto>>(_customerDal.CustomerListGetSelectedDate(StartDate, EndDate , CompanyId));
        }

        public IResult Delete(Customer model)
        {
            _customerDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Customer> GetById(int Id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Id == Id));
        }

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList().ToList());
        }

        public IDataResult<List<CustomerDto>> GetListDate(DateTime RegisterDate , int CompanyId)
        {
            return new SuccessDataResult<List<CustomerDto>>(_customerDal.CustomerListGetDate(RegisterDate, CompanyId));
        }

        public IResult Update(Customer model)
        {
            _customerDal.Update(model);
            return new SuccessResult(Messages.Updated);
        }

        IDataResult<List<Customer>> ICustomerService.SearchCustomer(string Plaka , int CompanyId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.SearchCustomer(Plaka, CompanyId));
        }
    }
}
