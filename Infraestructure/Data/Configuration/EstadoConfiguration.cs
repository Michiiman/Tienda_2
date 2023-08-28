using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration;

    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("estado");

            builder.Property(p => p.NombreEstado)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Pais)
            .WithMany(p => p.Estados)
            .HasForeignKey(p => p.IdPaisFk);

           /*  builder.HasKey(e => );
            builder.Property(e => ); */
        }
    }
