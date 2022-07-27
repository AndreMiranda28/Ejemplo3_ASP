using Almacen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Domain.Repositories
{
    public interface IProductoRepository
    {
        Task<List<Producto>> ObtenerByNombre(string entitiy,string idproducto);

    }
}
 