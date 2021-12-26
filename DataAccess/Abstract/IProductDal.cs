using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductListDto> ProductList(int CompanyId);
        List<ProductListDto> ProductListGetCategory(int CategoryId );
        int ProductExists(int Id);

    }
}
