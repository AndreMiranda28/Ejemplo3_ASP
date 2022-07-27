using Almacen.Application.UserCases.CategoriaUseCase.FiltrarCategoriaUseCase;
using Almacen.Application.UserCases.CategoriaUseCase.GuardarCategoriaUseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejemplo3_ASP.Controllers
{

    public class CategoriaController : WebApiControllerBase
    {
        private readonly IMediator _mediator;
        public CategoriaController(IMediator mediator
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
        public async Task<IActionResult> RealizarGuardar([FromBody] GuardarCategoriaRequest request)
        {
            var resultado = await _mediator.Send(request);
            return GetResult(resultado);
        }
        [HttpGet("filtrar")]
        public async Task<IActionResult> FiltrarCategoria([FromQuery] FiltrarCategoriaRequest request)
        {
            var resultado = await _mediator.Send(request);
            return GetResult(resultado);
        }

    }

}
