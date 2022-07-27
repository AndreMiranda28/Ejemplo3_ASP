using Almacen.Application.UserCases.CategoriaUseCase.GuardarEmpleadoUseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo3_ASP.Controllers
{

    public class EmpleadoController : WebApiControllerBase
    {
        private readonly IMediator _mediator;
        public EmpleadoController(IMediator mediator
            )
        {
            _mediator = mediator;
        }

        /// <summary>
        /// / HTTP POST api/Categoria/guardar
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("guardar")]
        public async Task<IActionResult> RealizarGuardar([FromBody] GuardarEmpleadoRequest request)
        {
            var resultado = await _mediator.Send(request);
            return GetResult(resultado);
        }
    }
}
