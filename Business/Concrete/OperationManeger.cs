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
    public class OperationManeger : IOperationService
    {
        private IOperationDal _operationDal;
        private IUserService _userService;
        public OperationManeger(IOperationDal operationDal , IUserService userService)
        {
            _operationDal = operationDal;
            _userService = userService;
        }
     

        public IDataResult<Operation> Add(OperationDto operationDto)
        {
            var user = _userService.GetByUserKey(operationDto.Key);
            var operation = new Operation
            {
                RegisterDate = DateTime.Now,
                FirstKm = operationDto.FirstKm,
                PeriodKm = operationDto.PeriodKm,
                LastKm = operationDto.LastKm,
                CustomerId = operationDto.CustomerId,
                UserId = user.Data.Id,
                OperationTypeId = operationDto.OperationTypeId,
                Note = operationDto.Note,
                Status = true
            };
            _operationDal.Add(operation);
            return new SuccessDataResult<Operation>(operation, Messages.Added);
        }

        public IResult Delete(Operation model)
        {
            _operationDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

      

        public IDataResult<Operation> GetById(int Id)
        {
            return new SuccessDataResult<Operation>(_operationDal.Get(x => x.Id == Id));
        }

        public IDataResult<List<Operation>> GetList()
        {
            return new SuccessDataResult<List<Operation>>(_operationDal.GetList().ToList());
        }

        public IDataResult<List<OperationListDto>> OperationList(int CustomerId)
        {
            return new SuccessDataResult<List<OperationListDto>>(_operationDal.OperationList(CustomerId));
        }

        public IDataResult<OperationPrintDto> OperationPrint(int Id)
        {
            return new SuccessDataResult<OperationPrintDto>(_operationDal.OperationPrint(Id));
        }

        public IResult Update(Operation model)
        {
            _operationDal.Update(model);
            return new SuccessResult(Messages.Updated);
        }
    }
}
