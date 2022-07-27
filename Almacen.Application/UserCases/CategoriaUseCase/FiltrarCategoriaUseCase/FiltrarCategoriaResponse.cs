using Almacen.Application.Common.Mappings;
using Almacen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.FiltrarCategoriaUseCase
{
    public class FiltrarCategoriaResponse : IMapFrom<Categoria, FiltrarCategoriaResponse>
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
    }
  
}
