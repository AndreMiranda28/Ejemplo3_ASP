using Almacen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<bool> Agregar(Categoria entitiy);
        Task<bool> Modificar(Categoria entitiy);
        Task<bool> Eliminar(int id);

        Task<Categoria> ObtenerById(string entitiy);

        Task<List<Categoria>> ObtenerByNombre(string entitiy);





    }
}
