using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize] 
    public class DashBoards : ControllerBase
    {

        private IDashBoardService _dashBoardService;
        public DashBoards(IDashBoardService dashBoardService)
        {
            _dashBoardService = dashBoardService;
        }


        [HttpGet("monthlydashboard")]
        public IActionResult MonthlyCustomer(int CompanyId)
        {
            var result = _dashBoardService.TotalDashboardInfoMonth(CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("dailydashboard")]
        public IActionResult DailyCustomer(int CompanyId)
        {
            var result = _dashBoardService.TotalDashboardInfoDay(CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("operataiontypereport")]
        public IActionResult OperataionTypeReport(int CompanyId)
        {
            var result = _dashBoardService.OperataionTypeReport(CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("productbycategoryreport")]
        public IActionResult ProductByCategoryReport(int CompanyId)
        {
            var result = _dashBoardService.ProductByCategoryReport(CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("operataiontypereportselecteddate")]
        public IActionResult OperataionTypeReportSelectedDate(int CompanyId , DateTime StartDate, DateTime EndDate)
        {
            var result = _dashBoardService.OperataionTypeReportSelectedDate(CompanyId, StartDate, EndDate);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("productbycategoryreportselecteddate")]
        public IActionResult ProductByCategoryReportSelectedDate(int CompanyId , DateTime StartDate, DateTime EndDate)
        {
            var result = _dashBoardService.ProductByCategoryReportSelectedDate(CompanyId , StartDate, EndDate);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
