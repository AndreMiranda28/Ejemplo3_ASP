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
    public class ProductoEntityTypeConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(p => p.IdCategoria);
            builder.Property(p => p.Nombre).HasColumnName("Nombre");
            builder.Property(p => p.IdCategoria).HasColumnName("IdCategoria");
            builder.Property(p => p.IdMarca).HasColumnName("IdMarca");
            builder.Property(p => p.IdModelo).HasColumnName("IdModelo");
            builder.Property(p => p.Stock).HasColumnName("Stock");
            builder.Property(p => p.StockMinimo).HasColumnName("StockMinimo");
            builder.Property(p => p.PrecioPorMenor).HasColumnName("PrecioPorMenor");
            builder.Property(p => p.PrecioPorMayor).HasColumnName("PrecioPorMayor");



        }
    }
}
