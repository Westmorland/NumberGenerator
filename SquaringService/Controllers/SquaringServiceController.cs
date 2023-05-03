using Microsoft.AspNetCore.Mvc;

namespace SquaringService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SquaringServiceController : ControllerBase
    {
        [HttpPost("square")]
        public ActionResult<int> SquareNumber([FromBody] int number)
        {
            int square = number * number;
            return Ok(square);
        }
    }
}