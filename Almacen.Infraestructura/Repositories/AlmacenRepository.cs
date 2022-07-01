using Almacen.Domain.Models;
using Almacen.Domain.Repositories;
using Almacen.Infraestructura.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Infraestructura.Repositories
{
    public class AlmacenRepository : IAlmacenRepository
    {
        public readonly AlmacenDbContext _context;
        public AlmacenRepository(AlmacenDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Agregar(Domain.Models.Almacen entitiy)
        {
            _context.Set<Domain.Models.Almacen>().Add(entitiy);
            await _context.SaveChangesAsync();
            return entitiy.IdAlmacen > 0;
        }

        public async Task<bool> Modificar(Domain.Models.Almacen entitiy)
        {
            _context.Set<Domain.Models.Almacen>().Update(entitiy);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
