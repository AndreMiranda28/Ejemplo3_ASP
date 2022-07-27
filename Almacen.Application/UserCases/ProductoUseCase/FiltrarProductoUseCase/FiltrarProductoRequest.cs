using Almacen.Application.Common;
using Almacen.Application.Common.Mappings;
using Almacen.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.ProductoUseCase.FiltrarProductoUseCase
{
   public class FiltrarProductoRequest : IRequest<IResult>, IMapFrom<FiltrarProductoRequest, Producto>
    {
        public string? Nombre { get; set; }
        public string? id { get; set; }

    }
}
