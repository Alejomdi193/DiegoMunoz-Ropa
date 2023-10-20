using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");
            
            builder.Property(p => p.CantidadProducir)
            .HasColumnType("int")
            .HasColumnType("CantidadProducir")
            .IsRequired()
            .HasMaxLength(1000);

            builder.Property(p => p.CantidadProducida)
            .HasColumnType("int")
            .HasColumnType("CantidadProducida")
            .IsRequired()
            .HasMaxLength(1000);

            builder.HasOne(p => p.Orden)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdOrdenFk);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdPrendaFk);

            builder.HasOne(p => p.Colorr)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdColorFk);


            builder.HasOne(p => p.Estado)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdEstadoFk);
        }
    }
}