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
    public class CompanyManeger : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManeger(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

      
        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList().ToList());
        }
        public IResult Add(Company company)
        {
            var result =  CompanyExists(company.CompanyName);
            
            if (result.Data!=null)
            {
                return new ErrorDataResult<Company>(Messages.CompanyControl);
            }
            _companyDal.Add(company);

            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Company> GetById(int Id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(x => x.Id == Id));
        }

        public IDataResult<Company> CompanyExists(string companyname)
        {
            return new SuccessDataResult<Company>( _companyDal.Get(x => x.CompanyName == companyname));
           
        }

        public IDataResult<List<CompanyDto>> SelectCompany()
        {
            return new SuccessDataResult<List<CompanyDto>>(_companyDal.GetCompanies());
        }
    }
}






 