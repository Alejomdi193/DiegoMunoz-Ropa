using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");

            
            builder.Property(p => p.Descripcion)
            .HasColumnType("varchar")
            .HasColumnName("Descripcion")
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(p => p.TipoEstado)
            .WithMany(p => p.Estados)
            .HasForeignKey(p => p.IdTipoEstadoFk);
        }
    }
}