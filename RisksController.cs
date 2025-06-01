using Microsoft.AspNetCore.Mvc;

namespace Risk.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RisksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "API جاهز للعمل 🎯" });
        }
    }
}
