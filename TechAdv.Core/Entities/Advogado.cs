namespace TechAdv.Core.Entities;

public class Advogado: Pessoa{
    public int AdvogadoId {get;set;}
    public string? CNA {get;set;}

    public int CasoJuridicoId {get;set;}
    public CasoJuridico? CasoJuridico {get;set;}

}