
namespace TechAdv.Core.Entities;

public class Pessoa: BaseEntity{
    public string? Nome {get;set;}
    public DateTimeOffset DataNascimento {get;set;}
    public string? CPF {get;set;}
}