using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOperationDetailDal : IEntityRepository<OperationDetail>
    {
        List<OperationDetailListDto> GetByOperationDetail(int OperationId);
        List<OperationDetailListDto> GetDashboardOperationListMonth(int CompanyId);
        List<OperationDetailListDto> GetDashboardOperationListDay(int CompanyId);

        OperationDetailListDto  GetByIdProduct(int Id);



    }
}
