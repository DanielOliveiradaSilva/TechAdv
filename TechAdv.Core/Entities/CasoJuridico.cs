
namespace TechAdv.Core.Entities;

public class CasoJuridico : BaseEntity
{
    public int CasoJuridicoId {get;set;}
    public DateTimeOffset Abertura {get;set;}
    public int ClienteId {get;set;}
    public Cliente? Cliente {get;set;}

    public int AdvogadoId {get;set;}
    public Advogado? Advogado {get;set;}

    
    public ICollection<Documento>? Documentos {get;set;}
    public string? Status {get;set;}
    public DateTimeOffset? Encerramento {get;set;}

}


