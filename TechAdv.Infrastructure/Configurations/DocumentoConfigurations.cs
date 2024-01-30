using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Configurations;

public class DocumentoConfigurations: IEntityTypeConfiguration<Documento>
{
    public void Configure(EntityTypeBuilder<Documento> builder){
        builder.HasKey(d => d.DocumentoId);
        builder.ToTable("Documentos");
    }
}