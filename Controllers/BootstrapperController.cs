using Microsoft.AspNetCore.Mvc;
using OverTheTop.Model;

namespace OverTheTop.Controllers;

[Route("[controller]")]
[ApiController]
public class BootstrapperController : ControllerBase
{
    public ActionResult<NeighborEnvelope> GetNeighbors(string ip)
    {
        return Ok(new NeighborEnvelope());
    }
}
