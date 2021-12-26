using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOperationDetailService
    {
        IDataResult<List<OperationDetailListDto>> OperationDetailList(int OperationId);
        IDataResult<OperationDetail> GetById(int Id);

        IDataResult<OperationDetailListDto> GetByIdProductInfo(int Id);
        IDataResult<List<OperationDetailListDto>> GetListMonth(int CompanyId);
        IDataResult<List<OperationDetailListDto>> GetListDay(int CompanyId);
        IResult Add(OperationDetail model);
        IResult Delete(OperationDetail model);
        IResult DeleteOperationDetailGetById(int Id);
        IResult Update(OperationDetail model);
    }
}


