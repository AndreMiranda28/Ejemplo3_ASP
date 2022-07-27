using Almacen.Application.UserCases.ProductoUseCase.FiltrarProductoUseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ejemplo3_ASP.Controllers
{
    public class ProductoController : WebApiControllerBase
    {
        private readonly IMediator _mediator;

        public ProductoController(IMediator mediator
             )
        {
            _mediator = mediator;
        }

        [HttpGet("filtrar")]
        public async Task<IActionResult> FiltrarProducto([FromQuery] FiltrarProductoRequest request)
        {
            var resultado = await _mediator.Send(request);
            return GetResult(resultado);
        }

    }
}
