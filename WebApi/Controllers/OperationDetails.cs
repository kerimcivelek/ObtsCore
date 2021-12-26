using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationDetails : ControllerBase
    {
        private IOperationDetailService _operationDetailService;

        public OperationDetails(IOperationDetailService operationDetailService)
        {
            _operationDetailService = operationDetailService;
        }

        [HttpGet("getallmonth")]
        public IActionResult GetListMonth(int CompanyId)
        {
            var result = _operationDetailService.GetListMonth(CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getallDay")]
        public IActionResult GetListDay(int CompanyId)
        {
            var result = _operationDetailService.GetListDay(CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _operationDetailService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyidproductinfo")]
        public IActionResult GetByIdProductInfo(int Id)
        {
            var result = _operationDetailService.GetByIdProductInfo(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getlistoperationid")]
        public IActionResult OperationDetailList(int OperationId)
        {
            var result = _operationDetailService.OperationDetailList(OperationId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }




        [HttpPost("add")]
        public IActionResult Add(OperationDetail model)
        {
            var result = _operationDetailService.Add(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(OperationDetail model)
        {
            var result = _operationDetailService.Update(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(OperationDetail model)
        {
            var result = _operationDetailService.Delete(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("deletegetbyid")]
        public IActionResult DeleteGetById(int Id)
        {
            var result = _operationDetailService.DeleteOperationDetailGetById(Id);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
