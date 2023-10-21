using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");

            builder.Property(p => p.Descripcion)
            .HasColumnType("varchar")
            .HasColumnName("descripcion")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.SueldoBase)
            .HasColumnType("int")
            .HasColumnName("SueldoBase")
            .IsRequired()
            .HasMaxLength(1000);
        }
    }
}