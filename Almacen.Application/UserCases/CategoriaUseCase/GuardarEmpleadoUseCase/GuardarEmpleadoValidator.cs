using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.GuardarEmpleadoUseCase
{
    public class GuardarEmpleadoValidator : AbstractValidator<GuardarEmpleadoRequest>
    {
        public GuardarEmpleadoValidator()
        {
            RuleFor(p => p.Nombres).NotEmpty().WithMessage("Especificar el nombre");
            //RuleFor(p => p.Nombre).MinimumLength(5).WithMessage("El minimo de caracteres tiene que ser mayor o igual a 5");
            RuleFor(p => p.IdEmpleado).Equal(0).When(c => c.EsNuevo).WithMessage("El id del modelo tiene que ser igual a cero");
            RuleFor(p => p.IdEmpleado).GreaterThan(0).When(c => !c.EsNuevo).WithMessage("El id del modelo tiene que ser mayor a cero");
        }
    }
}
