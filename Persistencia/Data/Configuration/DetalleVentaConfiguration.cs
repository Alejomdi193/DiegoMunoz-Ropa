using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");
            
            builder.Property(p => p.Cantidad)
            .HasColumnType("int")
            .HasColumnName("Cantidad")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.ValorUnit)
            .HasColumnType("int")
            .HasColumnName("ValorUnit")
            .IsRequired()
            .HasMaxLength(100);


            builder.HasOne(p => p.Venta)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdVentaFk);

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdInventarioFk);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdTallaFk);
        }
    }
}