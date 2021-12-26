using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Customers : ControllerBase
    {
        private ICustomerService _customerService;

        public Customers(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
      
        public IActionResult GetList()
        {
            var result = _customerService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getalldate")]
        public IActionResult GetListDate(DateTime RegisterDate , int CompanyId)
        {
            var result = _customerService.GetListDate(RegisterDate, CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getallselecteddate")]
        public IActionResult GetListSelectedDate(DateTime StartDate , DateTime EndDate ,int CompanyId)
        {
            var result = _customerService.CustomerListGetSelectedDate(StartDate , EndDate,  CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _customerService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("search")]
        public IActionResult SearchGetByKey(string Plaka , int CompanyId)
        {
            var result = _customerService.SearchCustomer(Plaka,CompanyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(CustomerDto customerDto)
        {
            var result = _customerService.Add(customerDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer model)
        {
            var result = _customerService.Update(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer model)
        {
            var result = _customerService.Delete(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}
