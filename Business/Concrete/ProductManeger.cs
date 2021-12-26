using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManeger : IProductService
    {
        private IProductDal _productDal;
        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product model)
        {
            _productDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Product model)
        {
            var result = ProductExists(model.Id);
            if (result.Data > 0)
            {
                return new ErrorDataResult<Customer>(Messages.ProductDeleteControl);
            }
            _productDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Product> GetById(int Id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Id == Id));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<int> ProductExists(int Id)
        {
          return new SuccessDataResult<int>(_productDal.ProductExists(Id));
        }

        public IDataResult<List<ProductListDto>> ProductListGetCategory(int CategoryId)
        {
            return new SuccessDataResult<List<ProductListDto>>(_productDal.ProductListGetCategory(CategoryId));
        }

        public IResult Update(Product model)
        {
            _productDal.Update(model);
            return new SuccessResult(Messages.Updated);
        }

        IDataResult<List<ProductListDto>> IProductService.ProductList(int CompanyId)
        {
            return new SuccessDataResult<List<ProductListDto>>(_productDal.ProductList(CompanyId));
        }
    }
}
