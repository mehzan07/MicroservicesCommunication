using Microsoft.AspNetCore.Mvc;

namespace Service1
{
    [ApiController]
    [Route("api/[controller]")]
    public class Service1Controller : ControllerBase
    {
        [HttpGet("service1")] // Define the route for Service1 endpoint
        public ActionResult<string> Get()
        {
            return "Response from Service1";
        }
    }
}
