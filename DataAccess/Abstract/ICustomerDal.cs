using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<Customer> SearchCustomer(string Plaka , int ComponyId);
        List<CustomerDto> CustomerListGetDate(DateTime RegisterDate , int ComponyId);
        List<CustomerDto> CustomerListGetSelectedDate(DateTime StartDate , DateTime EndDate , int CompanyId);
    }
}
