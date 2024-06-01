using FirstApiNet.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiNet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {

        var response = new User
        {
            Id = 1,
            Name = "Vinicius",
            Email = "J9b5Z@example.com",
            Phone = "123456789",
            Age = 30

        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = request.Name
        };

        return Created(string.Empty, response);
    }
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpddateUserProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        // Create logic for to list all the users
        var response = new List<User>(){
            new User
            {
                Id = 1,
                Name = "Vinicius",
                Email = "J9b5Z@example.com",
                Phone = "123456789",
                Age = 30
            },
            new User
            {
                Id = 2,
                Name = "Vinicius",
                Email = "J9b5Z@example.com",
                Phone = "123456789",
                Age = 30
            }
        };

        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }

}

