using Almacen.Application.Common;
using Almacen.Application.Common.Mappings;
using Almacen.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.GuardarEmpleadoUseCase
{
    public class GuardarEmpleadoRequest : IRequest<IResult>, IMapFrom<GuardarEmpleadoRequest, Empleado>
    {

        public int IdEmpleado { get; set; }
        public bool EsEmpresa { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public string TelefoneCasa { get; set; }
        public string TelefonoMovil { get; set; }

        public bool EsNuevo { get; set; }
    }
}
