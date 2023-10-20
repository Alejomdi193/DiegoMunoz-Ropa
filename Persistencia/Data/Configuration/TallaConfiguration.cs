using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TallaConfiguration : IEntityTypeConfiguration<Talla>
    {
        public void Configure(EntityTypeBuilder<Talla> builder)
        {
            builder.ToTable("Talla");

            
            builder.Property(p => p.Descripcion)
            .HasColumnType("varchar")
            .HasColumnType("Descripcion")
            .IsRequired()
            .IsUnicode()
            .HasMaxLength(100);
        }
    }
}