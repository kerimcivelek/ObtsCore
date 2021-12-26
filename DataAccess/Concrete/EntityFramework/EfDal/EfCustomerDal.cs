using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.EfDal
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ObtsContext>, ICustomerDal
    {
        public List<CustomerDto> CustomerListGetDate(DateTime RegisterDate , int ComponyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join ct in context.Customers on op.CustomerId equals ct.Id
                             join otype in context.OperationTypes on op.OperationTypeId equals otype.Id
                             join k in context.Users on op.UserId equals k.Id
                             where op.RegisterDate.Date == RegisterDate && op.Status == true && ct.CompanyId == ComponyId
                             select new CustomerDto
                             {
                                 Id = ct.Id,
                                 RegisterDate = op.RegisterDate,
                                 Plaka = ct.Plaka,
                                 Name = ct.Name,
                                 Surname = ct.Surname,
                                 Year = ct.Year,
                                 Fuel = ct.Fuel,
                                 Brand = ct.Brand,
                                 Gsm = ct.Gsm,
                                 Note = op.Note
                             };
                return result.ToList();
            }
        }

        public List<CustomerDto> CustomerListGetSelectedDate(DateTime StartDate, DateTime EndDate , int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                DateTime t1 = Convert.ToDateTime(StartDate.Date.ToShortDateString());
                DateTime t2 = Convert.ToDateTime(EndDate.Date.ToShortDateString()).AddDays(1).AddSeconds(-1);

                var result = from ct in context.Customers
                             where (ct.RegisterDate >= t1 && ct.RegisterDate <= t2) && ct.Status==true && ct.CompanyId==CompanyId
                              select new CustomerDto
                             {
                                 Id = ct.Id,
                                 RegisterDate = ct.RegisterDate,
                                 Plaka = ct.Plaka,
                                 Name = ct.Name,
                                 Surname = ct.Surname,
                                 Year = ct.Year,
                                 Fuel = ct.Fuel,
                                 Brand = ct.Brand,
                                 Gsm = ct.Gsm,
                                 Note = ct.Note
                             };
                return result.ToList();
            }
        }

        public List<Customer> SearchCustomer(string Plaka, int ComponyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from ct in context.Customers where ct.Plaka.Contains(Plaka) && ct.CompanyId== ComponyId
                             select new Customer
                             {
                                 Id = ct.Id,
                                 RegisterDate = ct.RegisterDate,
                                 Plaka = ct.Plaka,
                                 Name = ct.Name,
                                 Surname = ct.Surname,
                                 Year = ct.Year,
                                 Fuel = ct.Fuel,
                                 Brand = ct.Brand,
                                 Gsm = ct.Gsm,
                                 Note = ct.Note
                             };
                return result.ToList();
            }
        }
    }
}