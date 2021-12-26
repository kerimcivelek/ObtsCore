using Business.Abstract;
using Entities.Concrete;
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
    public class PackDetails : ControllerBase
    {
        private IPackDetailService _packDetailService;
        public PackDetails(IPackDetailService packDetailService)
        {
            _packDetailService = packDetailService;
        }

        [HttpGet("getlistpackid")]
        public IActionResult GetListPackId(int Id)
        {
            var result = _packDetailService.GetListPackId(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(PackDetail model)
        {
            var result = _packDetailService.Add(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(PackDetail model)
        {
            var result = _packDetailService.Delete(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
