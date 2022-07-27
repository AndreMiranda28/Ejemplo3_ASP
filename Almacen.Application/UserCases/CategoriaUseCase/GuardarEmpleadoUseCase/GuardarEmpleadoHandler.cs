using Almacen.Application.Common;
using Almacen.Domain.Models;
using Almacen.Domain.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.GuardarEmpleadoUseCase
{
    public class GuardarEmpleadoHandlerr : IRequestHandler<GuardarEmpleadoRequest, IResult>
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IMapper _mapper;

        public GuardarEmpleadoHandlerr(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            _empleadoRepository = empleadoRepository;
            _mapper = mapper;

        }
        public async Task<IResult> Handle(GuardarEmpleadoRequest request, CancellationToken cancellationToken)
        {
            var response = new GuardarEmpleadoResponse();

            try
            {
                var model = _mapper.Map<Empleado>(request);
                if (request.EsNuevo)
                {

                    response.Ok = await _empleadoRepository.Agregar(model);
                }
                else
                {

                   // response.Ok = await _empleadoRepository.Modificar(model);
                }
                if (response.Ok)
                {
                    return new SuccessResult<GuardarEmpleadoResponse>(response);

                }
                else
                {
                    return new FailureResult<IEnumerable<DetailError>>()
                    {
                        Value = new List<DetailError>
                        {
                            new DetailError("500","ERROR")
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                return new FailureResult();
            }
        }

    }
}
