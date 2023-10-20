using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            
            builder.Property(p => p.CodInv)
            .HasColumnType("varchar")
            .HasColumnType("CodInv")
            .IsUnicode()
            .IsRequired()
            .HasMaxLength(100);


            builder.Property(p => p.ValorVtaCop)
            .HasColumnType("int")
            .HasColumnType("ValorVtaCop")
            .IsRequired()
            .HasMaxLength(1000);

            builder.Property(p => p.ValorVtaUsd)
            .HasColumnType("int")
            .HasColumnType("ValorVtaUsd")
            .IsRequired()
            .HasMaxLength(1000);


            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.Inventarios)
            .HasForeignKey(p => p.IdPrendaFk);
        }
    }
}