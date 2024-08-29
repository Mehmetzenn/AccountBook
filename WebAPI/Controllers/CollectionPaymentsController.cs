using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionPaymentsController : ControllerBase
    {
        ICollectionPaymentsService _collectionPayments;
        public CollectionPaymentsController(ICollectionPaymentsService collectionPayments)
        {
            _collectionPayments = collectionPayments;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _collectionPayments.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CollectionPayments collectionPayments)
        {
            var result = _collectionPayments.Transaction(collectionPayments);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
