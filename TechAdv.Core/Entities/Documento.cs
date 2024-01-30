
namespace TechAdv.Core.Entities;

public class Documento : BaseEntity
{
  public int DocumentoId {get;set;}
  public int Codigo {get;set;}

  public int CasoJuridicoId {get;set;}
  public CasoJuridico? CasoJuridico {get;set;}
}