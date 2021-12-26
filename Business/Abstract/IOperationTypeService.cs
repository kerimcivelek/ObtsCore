using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOperationTypeService
    {
        IDataResult<OperationType> GetById(int Id);
        IDataResult<List<OperationTypeDto>> GetList();
 
        IResult Add(OperationType model);
        IResult Delete(OperationType model);
        IResult Update(OperationType model);
    }
}
