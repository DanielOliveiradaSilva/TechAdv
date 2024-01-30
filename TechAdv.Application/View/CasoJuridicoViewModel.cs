namespace TechAdv.Application.View;

public class CasoJuridicoViewModel
{
    public int Id { get; set; }
    public DateTimeOffset Abertura { get; set; }
    public AdvogadoViewModel? Advogado { get; set; }
    public List<DocumentoViewModel>? Documentos { get; set; }

    public ClienteViewModel? Cliente{get;set;}
    public string? Status { get; set; }

    public DateTimeOffset? Encerramento { get; set; }

}