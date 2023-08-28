using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration;

    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("producto");

            builder.Property(p => p.CodInterno)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.StockMin)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.StockMax)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Stock)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.ValorVta)
            .IsRequired()
            .HasColumnType("double");
        }
    }
