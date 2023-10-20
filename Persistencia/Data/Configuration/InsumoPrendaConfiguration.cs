using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");

            builder.HasKey(t => new { t.IdInsumoFk, t.IdPrendaFk });

            builder.Property(p => p.Cantidad)
            .HasColumnType("varchar")
            .HasColumnType("Cantidad")
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}