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
    public class EfOperationDetailDal : EfEntityRepositoryBase<OperationDetail, ObtsContext>, IOperationDetailDal
    {
        public List<OperationDetailListDto> GetByOperationDetail(int OperationId)
        {

            using (var contex = new ObtsContext())
            {
                var result = from op in contex.OperationDetails
                             join c in contex.Categories on op.CategoryId equals c.Id
                             join p in contex.Products on op.ProductId equals p.Id
                             where op.OperationId == OperationId
                             select new OperationDetailListDto
                             {
                                 Id = op.Id,
                                 CategoryName = c.Name,
                                 ProductName = p.ProductName,
                                 Price = op.Price,
                                 Quantity = op.Quantity,
                                 SumPrice = op.Quantity * op.Price,
                                 Discount = op.Discount,
                                 Total = op.Quantity * op.Price - op.Discount,
                                 ExternalProduct = op.ExternalProduct == true ? "X" : "",
                                 Note = op.Note
                             };
                return result.ToList();
            }
        }

        public List<OperationDetailListDto> GetDashboardOperationListMonth(int CompanyId)
        {
            using (var contex = new ObtsContext())
            {
                var result = from op in contex.OperationDetails
                             join o in contex.Operations on op.OperationId equals o.Id
                             join cust in contex.Customers on o.CustomerId equals cust.Id
                             join c in contex.Categories on op.CategoryId equals c.Id
                             join p in contex.Products on op.ProductId equals p.Id
                             where op.RegisterDate.Date.Month == DateTime.Now.Date.Month && op.RegisterDate.Date.Year ==DateTime.Now.Year && cust.CompanyId== CompanyId
                             select new OperationDetailListDto
                             {
                                 Id = op.Id,
                                 CategoryName = c.Name,
                                 ProductName = p.ProductName,
                                 Price = op.Price,
                                 Quantity = op.Quantity,
                                 SumPrice = op.Quantity * op.Price,
                                 Discount = op.Discount,
                                 Total = op.Quantity * op.Price - op.Discount,
                                 ExternalProduct = op.ExternalProduct == true ? "X" : "",
                                 Note = op.Note
                             };
                return result.ToList();
            }
        }

        public List<OperationDetailListDto> GetDashboardOperationListDay(int CompanyId)
        {
            using (var contex = new ObtsContext())
            {
                var result = from op in contex.OperationDetails
                             join o in contex.Operations on op.OperationId equals o.Id
                             join cust in contex.Customers on o.CustomerId equals cust.Id
                             join c in contex.Categories on op.CategoryId equals c.Id
                             join p in contex.Products on op.ProductId equals p.Id
                             where op.RegisterDate.Date == DateTime.Now.Date && cust.CompanyId == CompanyId
                             select new OperationDetailListDto
                             {
                                 Id = op.Id,
                                 CategoryName = c.Name,
                                 ProductName = p.ProductName,
                                 Price = op.Price,
                                 Quantity = op.Quantity,
                                 SumPrice = op.Quantity * op.Price,
                                 Discount = op.Discount,
                                 Total = op.Quantity * op.Price - op.Discount,
                                 ExternalProduct = op.ExternalProduct == true ? "X" : "",
                                 Note = op.Note
                             };
                return result.ToList();
            }
        }

        public  OperationDetailListDto  GetByIdProduct(int Id)
        {
            using (var contex = new ObtsContext())
            {
                var result = from op in contex.OperationDetails
                             join o in contex.Operations on op.OperationId equals o.Id
                             join cust in contex.Customers on o.CustomerId equals cust.Id
                             join c in contex.Categories on op.CategoryId equals c.Id
                             join p in contex.Products on op.ProductId equals p.Id
                             where op.Id == Id
                             select new OperationDetailListDto
                             {
                                 Id = op.Id,
                                 CategoryName = c.Name,
                                 ProductName = p.ProductName,
                                 CustomerId = cust.Id
                             };
                return result.FirstOrDefault();
            }
        }
    }
}






