using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public  interface ICategoryDal :IEntityRepository<Category>
    {
        List<CategoryListDto> CategoryList(int CompanyId);
    }
}
