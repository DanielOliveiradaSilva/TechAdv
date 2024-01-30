using Microsoft.AspNetCore.Mvc;

namespace TechAdv.WebApi.Controllers;

[ApiController]
[Route("api/v1/")]
public class AdvogadoController:ControllerBase
{


   [HttpGet("Advogados")]
    public IActionResult GetAll()
    {
        return NoContent( );
    }
    
    [HttpGet("advogado/{id}")]
    public IActionResult GetById(int id)
    {
        return NoContent( );
    }

    [HttpPost("advogado")]
    public IActionResult Post()
    {
        return NoContent( );
    }
    [HttpPut("advogado/{id}")]
    public IActionResult Put(int id)
    {
        return NoContent( );
    }
    [HttpDelete("advogado/{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent( );
    }

    
}