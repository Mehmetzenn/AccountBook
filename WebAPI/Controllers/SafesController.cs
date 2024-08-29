using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SafesController : ControllerBase
    {
        ISafeService _safeService;
        public SafesController(ISafeService safeService)
        {
            _safeService = safeService;
        }

        [HttpPost("add")]
        public IActionResult Add( Safe safe)
        {
            var result = _safeService.Add(safe);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Safe safe)
        {
            var result = _safeService.Delete(safe);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Safe safe)
        {
            var result = _safeService.Update(safe);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _safeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _safeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getsafedetailbyid")]
        public IActionResult GetSafeDetailById(int id, int selectedCurrencyId)
        {
            var result = _safeService.GetSafeDetailById(id, selectedCurrencyId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getsafedetail")]
        public IActionResult GetSafeDetail()
        {
            var result = _safeService.GetSafeDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
