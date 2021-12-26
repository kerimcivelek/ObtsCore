using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        IDataResult<Product> GetById(int Id);
        IDataResult<int> ProductExists(int Id);
        IDataResult<List<ProductListDto>> ProductListGetCategory(int CategoryId);
        IDataResult<List<Product>> GetList();
        IResult Add(Product model);
        IResult Delete(Product model);
        IResult Update(Product model);
        IDataResult<List<ProductListDto>> ProductList(int CompanyId);
    }
}
