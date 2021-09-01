using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Honeycomb.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class BookController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Books()
        {
            return new OkResult();
        }
    }
}