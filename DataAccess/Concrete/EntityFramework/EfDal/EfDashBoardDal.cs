using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework.EfDal
{
    public class EfDashBoardDal : EfEntityRepositoryBase<Customer, ObtsContext>, IDashBoardDal
    {
        public List<DashboardDto> OperataionTypeReport(int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join cust in context.Customers on op.CustomerId equals cust.Id
                             join d in context.OperationDetails on op.Id equals d.OperationId
                             join t in context.OperationTypes on op.OperationTypeId equals t.Id
                             where op.RegisterDate.Month == DateTime.Now.Month && op.RegisterDate.Year == DateTime.Now.Year && cust.CompanyId == CompanyId
                             group new { op, d, t } by new { t.Name } into g
                             select new DashboardDto
                             {
                                 OperationTypeName = g.Key.Name,
                                 totalOperation = g.Select(x => x.d.OperationId).Distinct().Count(),
                                 totalPrice = g.Sum(x => x.d.Quantity * x.d.Price - x.d.Discount)
                             };
                return result.ToList();
            }
        }
        public List<DashboardDto> ProductByCategoryReport(int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join cust in context.Customers on op.CustomerId equals cust.Id
                             join d in context.OperationDetails on op.Id equals d.OperationId
                             join t in context.OperationTypes on op.OperationTypeId equals t.Id
                             join ct in context.Categories on d.CategoryId equals ct.Id
                             join prd in context.Products on d.ProductId equals prd.Id
                             where op.RegisterDate.Month == DateTime.Now.Month && op.RegisterDate.Year == DateTime.Now.Year && cust.CompanyId == CompanyId
                             group new { op, d, ct, prd } by new { ct.Name, prd.ProductName } into g
                             select new DashboardDto
                             {
                                 CategoryName = g.Key.Name,
                                 ProductName = g.Key.ProductName,
                                 totalOperation = g.Select(x => x.d.Id).Count(),
                                 totalPrice = g.Sum(x => x.d.Quantity * x.d.Price - x.d.Discount)
                             };
                return result.ToList();
            }
        }
        public  DashboardTotalDto  TotalDashboardInfoDay(int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join cust in context.Customers on op.CustomerId equals cust.Id
                             join d in context.OperationDetails on op.Id equals d.OperationId
                             where op.RegisterDate.Date == DateTime.Now.Date && cust.CompanyId == CompanyId
                             group new { op, d } by new { } into g
                             select new DashboardTotalDto
                             {

                                 TotalCustomerThisDay = g.Select(x => x.op.CustomerId).Distinct().Count(),
                                 TotalPriceThisDay = g.Sum(x => x.d.Quantity * x.d.Price - x.d.Discount)
                             };
                return result.SingleOrDefault();
            }
        }
        public  DashboardTotalDto TotalDashboardInfoMonth(int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join cust in context.Customers on op.CustomerId equals cust.Id
                             join d in context.OperationDetails on op.Id equals d.OperationId
                             where op.RegisterDate.Month == DateTime.Now.Month && op.RegisterDate.Year == DateTime.Now.Year && cust.CompanyId == CompanyId
                             group new { op, d } by new {} into g
                             select new DashboardTotalDto
                             {
                                
                                 TotalCustomerThisMonth = g.Select(x => x.op.CustomerId).Distinct().Count(),
                                 TotalPriceThisMonth = g.Sum(x => x.d.Quantity * x.d.Price - x.d.Discount)
                             };
                return result.SingleOrDefault();
            }
        }


        public List<DashboardDto> ProductByCategoryReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate)
        {
            DateTime t1 = Convert.ToDateTime(StartDate.Date.ToShortDateString());
            DateTime t2 = Convert.ToDateTime(EndDate.Date.ToShortDateString()).AddDays(1).AddSeconds(-1);
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join cust in context.Customers on op.CustomerId equals cust.Id
                             join d in context.OperationDetails on op.Id equals d.OperationId
                             join t in context.OperationTypes on op.OperationTypeId equals t.Id
                             join ct in context.Categories on d.CategoryId equals ct.Id
                             join prd in context.Products on d.ProductId equals prd.Id
                             where (op.RegisterDate >= t1 && op.RegisterDate <= t2) && cust.CompanyId == CompanyId
                             group new { op, d, ct, prd } by new { ct.Name, prd.ProductName } into g
                             select new DashboardDto
                             {
                                 CategoryName = g.Key.Name,
                                 ProductName = g.Key.ProductName,
                                 totalOperation = g.Select(x => x.d.Id).Count(),
                                 totalPrice = g.Sum(x => x.d.Quantity * x.d.Price - x.d.Discount)
                             };
             
                return result.ToList();
            }
        }

        public List<DashboardDto> OperataionTypeReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate)
        {
            using (var context = new ObtsContext())
            {
                DateTime t1 = Convert.ToDateTime(StartDate.Date.ToShortDateString());
                DateTime t2 = Convert.ToDateTime(EndDate.Date.ToShortDateString()).AddDays(1).AddSeconds(-1);

                var result = from op in context.Operations
                             join cust in context.Customers on op.CustomerId equals cust.Id
                             join d in context.OperationDetails on op.Id equals d.OperationId
                             join t in context.OperationTypes on op.OperationTypeId equals t.Id
                             where (op.RegisterDate >= t1 && op.RegisterDate <= t2) && cust.CompanyId == CompanyId
                             group new { op, d, t } by new { t.Name } into g
                             select new DashboardDto
                             {
                                 OperationTypeName = g.Key.Name,
                                 totalOperation = g.Select(x => x.d.OperationId).Distinct().Count(),
                                 totalPrice = g.Sum(x => x.d.Quantity * x.d.Price - x.d.Discount)
                             };
                return result.ToList();
            }
        }
    }
}
