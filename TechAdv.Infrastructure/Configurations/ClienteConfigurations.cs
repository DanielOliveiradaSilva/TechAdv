using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Configurations;

public class ClienteCongigurations: IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder){
        builder.HasKey(c => c.ClienteId);
        builder.ToTable("Clientes");
    }
}