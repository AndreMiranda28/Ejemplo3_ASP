using Almacen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Infraestructura.Repositories.Base.EntityTypeConfiguration
{
    public class EmpleadoEntityTypeConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");
            builder.HasKey(p => p.IdEmpleado);
            builder.Property(p => p.EsEmpresa);
            builder.Property(p => p.Nombres);
            builder.Property(p => p.Apellidos);
            builder.Property(p => p.DNI);
            builder.Property(p => p.Direccion);
            builder.Property(p => p.Ciudad);
            builder.Property(p => p.Pais);
            builder.Property(p => p.Email);
            builder.Property(p => p.TelefoneCasa);
            builder.Property(p => p.TelefonoMovil);

        }
    }
}
