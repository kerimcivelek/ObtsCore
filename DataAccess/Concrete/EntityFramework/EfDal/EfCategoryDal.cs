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
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ObtsContext>, ICategoryDal
    {
        public List<CategoryListDto> CategoryList(int CompanyId)
        {
            using (var context = new ObtsContext())
            {
                var result = from ct in context.Categories where ct.CompanyId== CompanyId
                              select new CategoryListDto
                             {
                                 CategoryId = ct.Id,
                                 CategoryName = ct.Name
                             };
                return result.ToList();
            }
        }
    }
}
