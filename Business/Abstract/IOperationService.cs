using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOperationService
    {

        IDataResult<List<OperationListDto>> OperationList(int CustomerId);
        IDataResult<Operation> GetById(int Id);
        IDataResult<List<Operation>> GetList();
        IDataResult<Operation> Add(OperationDto operationDto);
        IResult Delete(Operation model);
        IResult Update(Operation model);
        IDataResult<OperationPrintDto> OperationPrint(int Id);
        
    }
}
