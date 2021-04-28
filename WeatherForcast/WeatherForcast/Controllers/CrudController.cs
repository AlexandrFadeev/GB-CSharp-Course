using Microsoft.AspNetCore.Mvc;

namespace WeatherForcast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        [HttpGet("read")]
        public IActionResult Read()
        {
            return Ok("Read endpoint works correctly");
        }
    }
}