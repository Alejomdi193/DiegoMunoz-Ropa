using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.Property(p => p.IdCliente)
            .HasColumnType("int")
            .HasColumnName("IdCliente")
            .IsRequired()
            .HasMaxLength(10000);

            builder.Property(p => p.Nombre)
            .HasColumnType("varchar")
            .HasColumnName("Nombre")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.FechaRegistro)
            .HasColumnType("date")
            .HasColumnName("FechaRegistro")
            .IsRequired()
            .HasMaxLength(100);


            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdTipoPersonaFk);


            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}