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
    public class OperationDetailManeger : IOperationDetailService
    {
        private IOperationDetailDal _operationDetailDal;
        public OperationDetailManeger(IOperationDetailDal operationDetailDal)
        {
            _operationDetailDal = operationDetailDal;
        }
        public IResult Add(OperationDetail model)
        {
            _operationDetailDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OperationDetail model)
        {
            _operationDetailDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteOperationDetailGetById(int Id)
        {
            var data = _operationDetailDal.Get(x=> x.Id==Id);
             _operationDetailDal.Delete(data);
           return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<OperationDetail> GetById(int Id)
        {
            return new SuccessDataResult<OperationDetail>(_operationDetailDal.Get(x=> x.Id==Id));
        }

        public IDataResult<List<OperationDetailListDto>> GetListMonth(int CompanyId)
        {
            return new SuccessDataResult<List<OperationDetailListDto>>(_operationDetailDal.GetDashboardOperationListMonth(CompanyId));
        }

        public IDataResult<List<OperationDetailListDto>> GetListDay(int CompanyId)
        {
            return new SuccessDataResult<List<OperationDetailListDto>>(_operationDetailDal.GetDashboardOperationListDay(CompanyId));
        }
        public IDataResult<List<OperationDetailListDto>> OperationDetailList(int OperationId)
        {
            return new SuccessDataResult<List<OperationDetailListDto>>(_operationDetailDal.GetByOperationDetail(OperationId));
        }

        public IResult Update(OperationDetail model)
        {
            _operationDetailDal.Update(model);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<OperationDetailListDto> GetByIdProductInfo(int Id)
        {
            return new SuccessDataResult<OperationDetailListDto>(_operationDetailDal.GetByIdProduct(Id));
        }
    }
}
