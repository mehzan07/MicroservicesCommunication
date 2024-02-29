using Microsoft.AspNetCore.Mvc;

namespace Service2
{
    [ApiController]
    [Route("api/[controller]")]
    public class Service2Controller : ControllerBase
    {
        [HttpGet("service2")] // Define the route for Service1 endpoint
        public ActionResult<string> Get()
        {
            return "Response from Service2";
        }

    }
}


