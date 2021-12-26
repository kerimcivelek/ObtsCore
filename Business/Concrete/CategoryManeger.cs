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
    public class CategoryManeger : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManeger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IResult Add(Category model)
        {
            
            _categoryDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Category model)
        {
            _categoryDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Category> GetById(int Id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.Id == Id));

        }

        public IDataResult<List<CategoryListDto>> GetList(int CompanyId)
        {
            return new SuccessDataResult<List<CategoryListDto>>(_categoryDal.CategoryList(CompanyId));
        }

        public IResult Update(Category model)
        {
            throw new NotImplementedException();
        }
    }
}
