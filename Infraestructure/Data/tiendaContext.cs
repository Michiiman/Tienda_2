using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infraestructure.Data;

public class TiendaContext : DbContext
{
    public TiendaContext(DbContextOptions<TiendaContext> options) : base(options)
    {
    }

    public DbSet<Producto> Productos{ get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<ProductoPersona> ProductoPersonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        // modelBuilder.Entity<ProductoPersona>().HasKey(p=>new{p.IdProductoFk,p.IdPersonaFk});
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}