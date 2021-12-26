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
    public class EfProductDal : EfEntityRepositoryBase<Product, ObtsContext>, IProductDal
    {
        public int ProductExists(int Id)
        {
            using (var context = new ObtsContext())
            {
                return (from o in context.OperationDetails
                              where o.ProductId == Id
                              select o).Count();
               
            }
        }

        public List<ProductListDto> ProductList(int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from p in context.Products
                             join ct in context.Categories on p.CategoryId equals ct.Id
                             where  ct.CompanyId == CompanyId
                             select new ProductListDto
                             {
                                 ProductId = p.Id,
                                 ProductName = p.ProductName
                             };
                return result.ToList();
            }
        }

        public List<ProductListDto> ProductListGetCategory(int CategoryId)
        {
            using (var context = new ObtsContext())
            {
                var result = from p in context.Products
                             join ct in context.Categories on p.CategoryId equals ct.Id
                             where p.CategoryId == CategoryId 
                             select new ProductListDto
                             {
                                 Id = p.Id,
                                 ProductId = p.Id,
                                 ProductName = p.ProductName
                             };
                return result.ToList();
            }
        }
    }
}



 