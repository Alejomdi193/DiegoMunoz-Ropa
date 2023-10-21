using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.Property(p => p.Id)
            .IsUnicode();
            
            builder.Property(p => p.Nombre)
            .HasColumnType("varchar")
            .HasColumnName("Nombre")
            .IsRequired()
            .HasMaxLength(100);
            
            builder.Property(p => p.FechaIngreso)
            .HasColumnType("date")
            .HasColumnName("FechaIngreso")
            .IsRequired()
            .HasMaxLength(100);


            builder.HasOne(p => p.Cargo)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdCargoFk);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdMunicipioFk);


        }
    }
}