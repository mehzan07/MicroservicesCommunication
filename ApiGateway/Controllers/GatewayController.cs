using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ApiGateway
{
    [ApiController]
    [Route("api/[controller]")]
    public class GatewayController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public GatewayController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("service1")]
        public async Task<ActionResult<string>> GetFromService1()
        {
            //var response = await _httpClient.GetStringAsync("http://localhost:5001/api/service1");
            // if it is not working, you should check the terminal to see which port is listening then chang to it.
            var response = await _httpClient.GetStringAsync("http://localhost:5080/api/service1");
            return response;
        }

        [HttpGet("service2")]
        public async Task<ActionResult<string>> GetFromService2()
        {
            //var response = await _httpClient.GetStringAsync("http://localhost:5002/api/service2");
            // if it is not working, you should check the terminal to see which port is listening then chang to it.
            var response = await _httpClient.GetStringAsync("http://localhost:5072/api/service2");
            return response;
        }
    }
}
