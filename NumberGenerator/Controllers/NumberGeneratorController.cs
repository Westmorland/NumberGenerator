using Microsoft.AspNetCore.Mvc;

namespace NumberGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberGeneratorController : ControllerBase
    {
        [HttpGet("generate")]
        public ActionResult<int> GenerateNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            return Ok(number);
        }
    }
}