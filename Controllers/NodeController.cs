using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OverTheTop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NodeController : ControllerBase
    {
        /// <summary>
        /// join the network
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPut("join")]
        public IActionResult JoinNetwork([FromQuery] string ip)
        {
            VideoHandler.NewClient(ip);
            return Ok();
        }
    }
}
