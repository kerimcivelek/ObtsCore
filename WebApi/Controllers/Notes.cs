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
    public class Notes : ControllerBase
    {
        private INoteService _noteService;
        public Notes(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpPost("add")]
        public IActionResult Add(Note model)
        {
            var result = _noteService.Add(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Note model)
        {
            var result = _noteService.Delete(model);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetList(int CustomerId)
        {
            var result = _noteService.GetList(CustomerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        



    }
}
