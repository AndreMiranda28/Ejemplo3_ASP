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
    public class AlmacenEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Models.Almacen>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Almacen> builder)
        {
            builder.ToTable("Almacen");
            builder.HasKey(p => p.IdAlmacen);
            builder.Property(p => p.Nombre).HasColumnName("Nombre");

        }
    }
}
