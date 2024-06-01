using Microsoft.AspNetCore.Mvc;

namespace FirstApiNet.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase
{
    public string Author { get; set; } = "Marcelo";

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
    [HttpGet("healthy")]
    public IActionResult Healthy(){
        return Ok("PORRRRAAA");
    }
}
