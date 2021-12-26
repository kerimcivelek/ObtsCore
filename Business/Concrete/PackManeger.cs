using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PackManeger : IPackService
    {
        private IPackDal _packDal;
        public PackManeger(IPackDal packDal)
        {
            _packDal = packDal;
        }
        public IResult Add(Pack model)
        {
            _packDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

       

        public IResult Delete(Pack model)
        {
            _packDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Pack>> GetList()
        {
            return new SuccessDataResult<List<Pack>>(_packDal.GetList());
        }




      
    }
}
