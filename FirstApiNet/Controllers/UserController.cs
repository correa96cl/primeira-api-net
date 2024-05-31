using Microsoft.AspNetCore.Mvc;

namespace FirstApiNet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string),StatusCodes.Status400BadRequest)]
    public IActionResult Get(int id, string nickname)
    {

        var response = new User
        {
            Name = "Vinicius",
            Email = "J9b5Z@example.com",
            Phone = "123456789",
            Age = 30   
            
        };
        return Ok(response);
    }
}