using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.Property(p => p.IdPrenda)
            .HasColumnType("int")
            .HasColumnName("IdPrenda")
            .HasMaxLength(100)
            .IsUnicode()
            .IsRequired();
            
            builder.Property(p => p.Nombre)
            .HasColumnType("varchar")
            .HasColumnName("Nombre")
            .HasMaxLength(100)
            .IsRequired();


            builder.Property(p => p.ValorUnitCop)
            .HasColumnType("int")
            .HasColumnName("ValorUnitCop")
            .HasMaxLength(100)
            .IsRequired();

            builder.Property(p => p.ValorUnitUsd)
            .HasColumnType("int")
            .HasColumnName("ValorUnitUsd")
            .HasMaxLength(100)
            .IsRequired();


            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdEstadoFk);

            builder.HasOne(p => p.TipoProteccion)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdTipoProteccionFk);
            
            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdGeneroFk);


        }
    }
}