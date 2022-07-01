using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.GuardarCategoriaUseCase
{
    public class GuardarCategoriaValidator:AbstractValidator<GuardarCategoriaRequest>
    {
        public GuardarCategoriaValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("Especificar el nombre");
            RuleFor(p => p.Nombre).MinimumLength(5).WithMessage("El minimo de caracteres tiene que ser mayor o igual a 5");
            RuleFor(p => p.IdCategoria).Equal(0).When(c => c.EsNuevo).WithMessage("El id del modelo tiene que ser igual a cero");
            RuleFor(p => p.IdCategoria).GreaterThan(0).When(c => !c.EsNuevo).WithMessage("El id del modelo tiene que ser mayor a cero");
        }
    }
}
