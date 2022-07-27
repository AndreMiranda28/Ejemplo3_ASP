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
    public class ProductoRepository : IProductoRepository
    {
        public readonly AlmacenDbContext _context;
        public ProductoRepository(AlmacenDbContext context)
        {
            _context = context;
        }
        public async Task<List<Producto>> ObtenerByNombre(string filtroByName, string idproducto)
        {
            var data = await _context.Set<Producto>().Where(x => x.Nombre==filtroByName || x.IdProducto==Convert.ToInt32(idproducto)).ToListAsync();
            return data;
        }
    }
}
