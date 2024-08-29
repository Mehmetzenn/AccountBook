using Business.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SafeBalanceController : ControllerBase
    {
        ISafeBalanceService _safeBalanceService;
        public SafeBalanceController(ISafeBalanceService safeBalanceService)
        {
            _safeBalanceService = safeBalanceService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _safeBalanceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
