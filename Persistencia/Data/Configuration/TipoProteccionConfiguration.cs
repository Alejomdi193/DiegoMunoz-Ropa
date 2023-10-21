using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProteccion>
    {
        public void Configure(EntityTypeBuilder<TipoProteccion> builder)
        {
            builder.ToTable("TipoProteccion");

            
            builder.Property(p => p.Descripcion)
            .HasColumnType("varchar")
            .HasColumnName("Descripcion")
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}