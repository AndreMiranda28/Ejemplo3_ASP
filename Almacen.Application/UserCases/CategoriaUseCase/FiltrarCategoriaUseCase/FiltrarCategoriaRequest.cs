using Almacen.Application.Common;
using Almacen.Application.Common.Mappings;
using Almacen.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.FiltrarCategoriaUseCase
{
    public class FiltrarCategoriaRequest : IRequest<IResult>, IMapFrom<FiltrarCategoriaRequest, Categoria>
    {
        public string Nombre { get; set; }
    }

}
