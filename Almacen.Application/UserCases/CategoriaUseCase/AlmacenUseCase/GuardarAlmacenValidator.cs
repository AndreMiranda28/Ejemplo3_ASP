using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.AlmacenUseCase
{
    public class GuardarAlmacenValidator : AbstractValidator<GuardarAlmacenRequest>
    {
        public GuardarAlmacenValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("Especificar almacén");
            RuleFor(p => p.Nombre).MinimumLength(5).WithMessage("El minimo de caracteres tiene que ser mayor o igual a 6");
            RuleFor(p => p.IdAlmacen).Equal(0).When(c => c.EsNuevo).WithMessage("El id del modelo tiene que ser igual a cero");
            RuleFor(p => p.IdAlmacen).GreaterThan(0).When(c => !c.EsNuevo).WithMessage("El id del modelo tiene que ser mayor a cero");
        }
    }
}
