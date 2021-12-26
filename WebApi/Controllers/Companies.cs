using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class Companies : ControllerBase
    {
        ICompanyService _companyService;

        public Companies(ICompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet("getall")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetList()
        {
            var result = _companyService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("selectcompany")]
        public IActionResult SelectCompany()
        {
            var result = _companyService.SelectCompany();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyId")]
      
        public IActionResult GetById(int Id)
        {
            var result = _companyService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Company model)
        {
            var result = _companyService.Add(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }    
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Company model)
        {
            var result = _companyService.Update(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Company model)
        {
            var result = _companyService.Delete(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}
