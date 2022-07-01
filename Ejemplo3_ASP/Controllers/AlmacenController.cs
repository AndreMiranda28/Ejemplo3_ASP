using Almacen.Application.UserCases.CategoriaUseCase.AlmacenUseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo3_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AlmacenController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// / HTTP POST api/Almacen/guardar
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// // FROMBODY SE USA CUANDO QUIERES PASAR UN OBJETO COMO PARAMETRO
        [HttpPost("guardar")]
        public async Task<IActionResult> RealizarGuardar([FromBody] GuardarAlmacenRequest request)
        {
            var resultado = await _mediator.Send(request);
            return Ok(resultado);
        }
    }
}
