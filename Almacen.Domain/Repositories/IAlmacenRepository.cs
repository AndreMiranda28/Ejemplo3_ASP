using Almacen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Domain.Repositories
{
    public interface IAlmacenRepository
    {
        Task<bool> Agregar(Models.Almacen almacen);
        Task<bool> Modificar(Models.Almacen almacen);
    }
}
