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
    public class OperationTypes : ControllerBase
    {
        private IOperationTypeService _operationTypeService;

        public OperationTypes(IOperationTypeService operationTypeService)
        {
            _operationTypeService = operationTypeService;
        }


        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _operationTypeService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _operationTypeService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest("Kayıt Yok");
        }

        [HttpPost("add")]
        public IActionResult Add(OperationType model)
        {
            var result = _operationTypeService.Add(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("update")]
        public IActionResult Update(OperationType model)
        {
            var result = _operationTypeService.Update(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(OperationType model)
        {
            var result = _operationTypeService.Delete(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
