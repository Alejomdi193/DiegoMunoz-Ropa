using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ColorrConfiguration : IEntityTypeConfiguration<Colorr>
    {
        public void Configure(EntityTypeBuilder<Colorr> builder)
        {
            builder.ToTable("Color");
            
            builder.Property(p => p.Descripcion)
            .HasColumnType("varchar")
            .HasColumnType("Descripcion")
            .IsRequired()
            .HasMaxLength(100);

            
        }
    }
}