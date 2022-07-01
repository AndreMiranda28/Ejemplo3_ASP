using Almacen.Application.Common;
using Almacen.Application.Common.Mappings;
using Almacen.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.AlmacenUseCase
{
    public class GuardarAlmacenRequest : IRequest<IResult>, IMapFrom<GuardarAlmacenRequest, Domain.Models.Almacen>
    {
        public int IdAlmacen { get; set; }
        public string Nombre { get; set; }
        public bool EsNuevo { get; set; }
    }
}
