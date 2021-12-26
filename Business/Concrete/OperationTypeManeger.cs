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
    public class OperationTypeManeger : IOperationTypeService
    {
        private IOperationTypeDal _operationTypeDal;

        public OperationTypeManeger(IOperationTypeDal operationTypeDal)
        {
            _operationTypeDal = operationTypeDal;
        }

        public IResult Add(OperationType model)
        {
            _operationTypeDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OperationType model)
        {
            _operationTypeDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<OperationType> GetById(int Id)
        {
            return new SuccessDataResult<OperationType>(_operationTypeDal.Get(x => x.Id == Id));
        }

        public IDataResult<List<OperationTypeDto>> GetList()
        {
            return new SuccessDataResult<List<OperationTypeDto>>(_operationTypeDal.GetList().ToList());
        }


        public IResult Update(OperationType model)
        {
            _operationTypeDal.Update(model);
            return new SuccessResult(Messages.Updated);
        }
    }
}
