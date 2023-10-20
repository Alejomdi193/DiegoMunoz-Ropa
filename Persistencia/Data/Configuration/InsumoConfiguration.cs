using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("Insumo");

            
            builder.Property(p => p.Nombre)
            .HasColumnType("varchar")
            .HasColumnType("Nombre")
            .IsUnicode()
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.ValorUnit)
            .HasColumnType("int")
            .HasColumnType("ValorUnit")
            .IsRequired()
            .HasMaxLength(1000);


            builder.Property(p => p.StockMax)
            .HasColumnType("int")
            .HasColumnType("stockmax")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.StockMin)
            .HasColumnType("int")
            .HasColumnType("stockmin")
            .IsRequired()
            .HasMaxLength(100);


        }
    }
}