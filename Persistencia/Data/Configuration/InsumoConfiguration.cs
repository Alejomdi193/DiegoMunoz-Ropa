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
            .HasColumnName("Nombre")
            .IsUnicode()
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.ValorUnit)
            .HasColumnType("int")
            .HasColumnName("ValorUnit")
            .IsRequired()
            .HasMaxLength(1000);


            builder.Property(p => p.StockMax)
            .HasColumnType("int")
            .HasColumnName("stockmax")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.StockMin)
            .HasColumnType("int")
            .HasColumnName("stockmin")
            .IsRequired()
            .HasMaxLength(100);


            builder.HasMany(p => p.Proveedores)
            .WithMany(p => p.Insumo)
            .UsingEntity<InsumoProveedor>(
                j=> j
                    .HasOne(p => p.Proveedor)
                    .WithMany(p => p.InsumoProveedores)
                    .HasForeignKey(p => p.IdProoveedorFk),

                    j => j
                    .HasOne(p => p.Insumo)
                    .WithMany(p => p.InsumoProveedores)
                    .HasForeignKey(p => p.IdInsumoFk),

                    j => 
                    {
                        j.ToTable("InsumoProveedores");
                        j.HasKey(p => new {p.IdInsumoFk, p.IdProoveedorFk});
                    }
            );



            builder.HasMany(p => p.Prendas)
            .WithMany(p => p.Insumos)
            .UsingEntity<InsumoPrenda>(
                j=> j
                    .HasOne(p => p.Prenda)
                    .WithMany(p => p.InsumoPrendas)
                    .HasForeignKey(p => p.IdInsumoFk),

                    j => j
                    .HasOne(p => p.Insumo)
                    .WithMany(p => p.InsumoPrendas)
                    .HasForeignKey(p => p.IdPrendaFk),

                    j => 
                    {
                        j.ToTable("InsumoProveedores");
                        j.HasKey(p => new {p.IdInsumoFk, p.IdPrendaFk});

                        j.Property(p => p.Cantidad)
                        .IsRequired()
                        .HasColumnName("Cantidad")
                        .HasColumnType("int");
                    }
            );


        }
    }
}