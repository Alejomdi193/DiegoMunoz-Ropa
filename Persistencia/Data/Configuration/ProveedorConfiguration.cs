using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.Property(p => p.NitProveedor)
            .HasColumnType("int")
            .HasColumnName("NitProveedor")
            .HasMaxLength(100)
            .IsUnicode()
            .IsRequired();


            builder.Property(p => p.Nombre)
            .HasColumnType("varchar")
            .HasColumnName("Nombre")
            .HasMaxLength(100)
            .IsRequired();


            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdTipoPersonaFk);


            
            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdMunicipioFk);

        }
    }
}