using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            
            builder.Property(p => p.Fecha)
            .HasColumnType("date")
            .HasColumnType("Fecha")
            .IsRequired()
            .HasMaxLength(100);


            builder.HasOne(p=> p.Empleado)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.IdEmpleadoFk);


            builder.HasOne(p=> p.Cliente)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.IdClienteFk);

            builder.HasOne(p=> p.FormaPago)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.IdFormaPagoFk);
        }
    }
}