using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDashBoardDal : IEntityRepository<Customer>
    {
         DashboardTotalDto TotalDashboardInfoMonth(int CompanyId);
         DashboardTotalDto  TotalDashboardInfoDay(int CompanyId);
        List<DashboardDto> OperataionTypeReport(int CompanyId);
        List<DashboardDto> ProductByCategoryReport(int CompanyId);

        List<DashboardDto> OperataionTypeReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate);
        List<DashboardDto> ProductByCategoryReportSelectedDate(int CompanyId , DateTime StartDate, DateTime EndDate);
    }
}
