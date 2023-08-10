using Microsoft.AspNetCore.Mvc;

namespace WebAPI3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from WebAPI3");
        }
    }
}
