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
    public class EfCompanyDal : EfEntityRepositoryBase<Company, ObtsContext>, ICompanyDal
    {
        public List<CompanyDto> GetCompanies()
        {
            using (var context = new ObtsContext())
            {
                var result = from c in context.Companies
                             where c.Status == true
                             select new CompanyDto
                             {
                                 CompanyId = c.Id,
                                 Name = c.CompanyName
                             };

                return result.ToList();         
            }
        }
    }
}
