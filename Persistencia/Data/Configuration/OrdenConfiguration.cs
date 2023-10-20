using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            
            builder.Property(p => p.Fecha)
            .HasColumnType("date")
            .HasColumnType("Fecha")
            .IsRequired();

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdEmpleadoFk);

            builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdClienteFk);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdEstadoFk);
        }
    }
}