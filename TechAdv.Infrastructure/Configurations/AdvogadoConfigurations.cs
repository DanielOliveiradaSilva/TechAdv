using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Configurations;

public class AdvogadoConfigurations: IEntityTypeConfiguration<Advogado>
{
    public void Configure(EntityTypeBuilder<Advogado> builder){
        builder.HasKey(a => a.AdvogadoId);
        builder.ToTable("Advogados");
    }
}