using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PackDetailManeger : IPackDetailService
    {
        private IPackDetailDal _packDetailDal;
        public PackDetailManeger(IPackDetailDal packDetailDal)
        {
            _packDetailDal = packDetailDal;
        }
        public IResult Add(PackDetail model)
        {
            _packDetailDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(PackDetail model)
        {
            _packDetailDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<PackDetail>> GetListPackId(int Id)
        {
            return new SuccessDataResult<List<PackDetail>>(_packDetailDal.GetList(x=> x.PackId==Id).ToList());
        }
    }
}
