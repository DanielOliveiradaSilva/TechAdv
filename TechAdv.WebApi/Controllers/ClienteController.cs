using Microsoft.AspNetCore.Mvc;

namespace TechAdv.WebApi.Controllers;

[ApiController]
[Route("api/v1/")]
public class ClienteController:ControllerBase{

    [HttpGet("clientes")]
    public IActionResult GetAll()
    {
        return NoContent( );
    }

    [HttpGet("cliente/{id}")]
    public IActionResult GetById(int id)
    {
        return NoContent( );
    }

    [HttpPost("clientes")]
    public IActionResult Post()
    {
        return NoContent( );
    }
    [HttpPut("cliente/{id}")]
    public IActionResult Put(int id)
    {
        return NoContent( );
    }
    [HttpDelete("cliente/{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent( );
    }

}