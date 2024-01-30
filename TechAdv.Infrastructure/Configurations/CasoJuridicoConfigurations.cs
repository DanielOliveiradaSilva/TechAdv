using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Configurations;

public class CasoJuridicoConfigurations: IEntityTypeConfiguration<CasoJuridico>
{
    public void Configure(EntityTypeBuilder<CasoJuridico> builder){
        builder.HasKey(c => c.CasoJuridicoId);
        builder.ToTable("CasoJuridicos");
        builder.HasOne(a => a.Advogado).WithOne(cj => cj.CasoJuridico).HasForeignKey<CasoJuridico>(a => a.AdvogadoId);
        builder.HasOne(a => a.Advogado).WithOne(cj => cj.CasoJuridico).HasForeignKey<CasoJuridico>(a => a.ClienteId);
        builder.HasMany(d => d.Documentos).WithOne(cj => cj.CasoJuridico);
       
    }
}