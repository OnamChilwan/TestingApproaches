using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.Api.Models;
using Book.Api.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Book.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IGetStockQuery _getStockQuery;

        public BookController(IGetStockQuery getStockQuery)
        {
            _getStockQuery = getStockQuery;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return new OkResult();
        }
        
        [HttpPut]
        public async Task<IActionResult> Reservation(BookReservationRequest request)
        {
            var errors = await Validate(request);

            if (errors.Any())
            {
                return new BadRequestObjectResult(errors);
            }
            
            return new CreatedResult("http://foo.com/", request);
        }

        private async Task<List<ApiError>> Validate(BookReservationRequest request)
        {
            var errors = new List<ApiError>();

            if (string.IsNullOrEmpty(request.ISBN))
            {
                errors.Add(new ApiError {ErrorCode = "InvalidISBN"});
            }

            if (string.IsNullOrEmpty(request.MembershipNumber))
            {
                errors.Add(new ApiError {ErrorCode = "InvalidMemberNo"});
            }

            if (await _getStockQuery.Execute(request.ISBN) <= 0)
            {
                errors.Add(new ApiError {ErrorCode = "InsufficientStock"});
            }

            return errors;
        }
    }
}