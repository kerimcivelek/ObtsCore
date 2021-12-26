using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        IDataResult<Category> GetById(int Id);
        IDataResult<List<CategoryListDto>> GetList(int CompanyId);
        IResult Add(Category model);
        IResult Delete(Category model);
        IResult Update(Category model);
    }
}
