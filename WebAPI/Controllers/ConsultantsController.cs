using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        IConsultantService _consultantService;

        public ConsultantsController(IConsultantService consultantService)
        {
            _consultantService = consultantService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _consultantService.GetAll();

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int consultantId)
        {
            var result = _consultantService.GetById(consultantId);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Consultant consultant)
        {
            var result = _consultantService.Add(consultant);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Consultant consultant)
        {
            var result = _consultantService.Delete(consultant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Consultant consultant)
        {
            var result = _consultantService.Update(consultant);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
