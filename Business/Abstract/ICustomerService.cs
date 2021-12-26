using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int Id);
        IDataResult<Customer> CustomerExists(string Plaka);
        IDataResult<List<Customer>> SearchCustomer(string Plaka , int CompanyId);
        IDataResult<List<Customer>> GetList();
        IDataResult<List<CustomerDto>> GetListDate(DateTime RegisterDate,int CompanyId);
        IDataResult<List<CustomerDto>> CustomerListGetSelectedDate(DateTime StartDate, DateTime EndDate , int CompanyId);
        IDataResult<Customer> Add(CustomerDto customerDto );
        IResult Delete(Customer model);
        IResult Update(Customer model);
    }
}
