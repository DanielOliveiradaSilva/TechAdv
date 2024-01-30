using Microsoft.EntityFrameworkCore;

namespace TechAdv.Infrastructure.Context;

public class TechAdvContext: DbContext{

    public TechAdvContext(DbContextOptions<TechAdvContext> options) : base(options){

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechAdvContext).Assembly);
    }
}