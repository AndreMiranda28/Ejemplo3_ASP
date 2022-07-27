using Almacen.Application.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo3_ASP.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class WebApiControllerBase : ControllerBase
        {
            protected IActionResult GetResult(IResult resultado)
            {
                if (resultado is SuccessResult)
                    return Ok(resultado);
                else
                    return BadRequest(resultado);
            }
        }

    
}
