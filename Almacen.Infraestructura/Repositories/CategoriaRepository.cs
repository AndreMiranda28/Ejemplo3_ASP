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
    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly AlmacenDbContext _context;
        public CategoriaRepository(AlmacenDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Agregar(Categoria entitiy)
        {
            _context.Set<Categoria>().Add(entitiy);
            await _context.SaveChangesAsync();
            return entitiy.IdCategoria > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            _context.Set<Categoria>().Remove(new Categoria() { IdCategoria = id });
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Modificar (Categoria entity)
        {
            _context.Set<Categoria>().Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Categoria> ObtenerById(int id)
        {
            return await _context.Set<Categoria>().FindAsync(id);
        }
        public async Task<List<Categoria>> ObtenerByNombre (string filtroByName)
        {
            return await _context.Set<Categoria>().Where(x => x.Nombre.Contains(filtroByName)).ToListAsync();
        }
    }
}
