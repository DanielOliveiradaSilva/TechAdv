using Microsoft.AspNetCore.Mvc;

namespace TechAdv.WebApi.Controllers;

[ApiController]
[Route("api/v1/")]
public class DocumentoController:ControllerBase
{

    [HttpGet("documentos")]
    public IActionResult GetAll(){
        return NoContent( );
    }

    [HttpGet("documento/{id}")]
    public IActionResult GetById(int id){
        return NoContent( );
    }
    [HttpGet("documento/{Codigo}")]
    public IActionResult GetByCodigo(int Codigo){
        return NoContent( );
    }

    [HttpPost("documento")]
    public IActionResult Post(){
        return NoContent( );
    }


    [HttpPut("documento/{id}")]
    public IActionResult Put(){
        return NoContent( );
    }

    [HttpDelete("documento/{id}")]
    public IActionResult Delete(){
        return NoContent( );
    }
}