using Microsoft.AspNetCore.Mvc;

namespace TechAdv.WebApi.Controllers;

[ApiController]
[Route("api/v1/")]
public class CasoJuridicoControler:ControllerBase{

    [HttpGet("casos")]
    public IActionResult GetAll(){
        return NoContent( );
    }

    [HttpGet("caso/{id}")]
    public IActionResult GetById(int id){
        return NoContent( );
    }
    [HttpGet("caso/{id}/documentos")]
    public IActionResult GetAllDocumentos(int id){
        return NoContent( );
    }

    [HttpGet("caso/{id}/advogado")]
    public IActionResult GetAdvogado(int id){
        return NoContent( );
    }

    [HttpGet("caso/{id}/cliente")]
    public IActionResult GetCliente(int id){
        return NoContent( );
    }

    [HttpPost("caso")]
    public IActionResult Post(){
        return NoContent( );
    }
    [HttpPut("caso/{id}")]
    public IActionResult Put(int id){
        return NoContent( );
    }
    
    [HttpDelete("caso/{id}")]
    public IActionResult Delete(int id){
        return NoContent( );
    }
}