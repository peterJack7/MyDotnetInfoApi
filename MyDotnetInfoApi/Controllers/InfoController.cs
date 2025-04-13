using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDotnetInfoApi.Models;

namespace MyDotnetInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<InfoResponse> GetInfo()
        {
            var response = new InfoResponse
            {
                Name = "My Dotnet App",
                Version = "1.0.0",
                Status = "Running"
            };

            return Ok(response);
        }
    }
}
