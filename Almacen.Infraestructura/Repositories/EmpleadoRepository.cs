using Almacen.Domain.Models;
using Almacen.Domain.Repositories;
using Almacen.Infraestructura.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Infraestructura.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        public readonly AlmacenDbContext _context;
        public EmpleadoRepository(AlmacenDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Agregar(Empleado entitiy)
        {
            _context.Set<Empleado>().Add(entitiy);
            await _context.SaveChangesAsync();
            return entitiy.IdEmpleado > 0;
        }
    }
}
