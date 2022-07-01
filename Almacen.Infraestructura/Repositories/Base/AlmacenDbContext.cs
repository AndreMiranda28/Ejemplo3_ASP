using Almacen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Infraestructura.Repositories.Base
{
    public class AlmacenDbContext: DbContext
    {
        public AlmacenDbContext(DbContextOptions<AlmacenDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Domain.Models.Almacen> Almacenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlmacenDbContext).Assembly);

        }

    }
}
