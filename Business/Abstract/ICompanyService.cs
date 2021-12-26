using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICompanyService
    {
        IDataResult<List<Company>> GetList();
        IDataResult<List<CompanyDto>> SelectCompany();
        IDataResult<Company> CompanyExists(string companyname);
        IDataResult<Company> GetById(int Id);
        IResult Add(Company company);
        IResult Delete(Company company);
        IResult Update(Company company);
    }
}
