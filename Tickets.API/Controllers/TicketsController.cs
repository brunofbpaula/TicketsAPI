using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tickets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {

            return Ok(200);
        }

    }
}
