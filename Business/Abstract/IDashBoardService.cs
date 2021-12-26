using Core.Utilities.Results;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IDashBoardService
    {
        IDataResult<DashboardTotalDto> TotalDashboardInfoMonth(int CompanyId);

        IDataResult<DashboardTotalDto> TotalDashboardInfoDay(int CompanyId);

        IDataResult<List<DashboardDto>>  OperataionTypeReport (int CompanyId);
        IDataResult<List<DashboardDto>> ProductByCategoryReport(int CompanyId);

        IDataResult<List<DashboardDto>> OperataionTypeReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate);
        IDataResult<List<DashboardDto>> ProductByCategoryReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate);
    }
}
