using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DashBoardManeger : IDashBoardService
    {

        private IDashBoardDal _dashboardDal;

        public DashBoardManeger(IDashBoardDal dashboardDal)
        {
            _dashboardDal = dashboardDal;
        }
        public IDataResult<List<DashboardDto>> OperataionTypeReport(int CompanyId)
        {
            return new SuccessDataResult<List<DashboardDto>>(_dashboardDal.OperataionTypeReport(CompanyId));
        }
        public IDataResult<List<DashboardDto>> ProductByCategoryReport(int CompanyId)
        {
            return new SuccessDataResult<List<DashboardDto>>(_dashboardDal.ProductByCategoryReport( CompanyId));
        }
        public IDataResult<DashboardTotalDto> TotalDashboardInfoDay(int CompanyId)
        {
            return new SuccessDataResult<DashboardTotalDto>(_dashboardDal.TotalDashboardInfoDay(CompanyId));
        }
        public IDataResult<DashboardTotalDto> TotalDashboardInfoMonth(int CompanyId)
        {
            return new SuccessDataResult<DashboardTotalDto>(_dashboardDal.TotalDashboardInfoMonth(CompanyId));
        }
        public IDataResult<List<DashboardDto>> ProductByCategoryReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate)
        {
            return new SuccessDataResult<List<DashboardDto>>(_dashboardDal.ProductByCategoryReportSelectedDate(CompanyId , StartDate, EndDate));
        }
        public IDataResult<List<DashboardDto>> OperataionTypeReportSelectedDate(int CompanyId, DateTime StartDate, DateTime EndDate)
        {
            return new SuccessDataResult<List<DashboardDto>>(_dashboardDal.OperataionTypeReportSelectedDate(CompanyId, StartDate, EndDate));
        }
    }
}
