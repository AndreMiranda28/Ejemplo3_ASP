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

namespace Almacen.Application.UserCases.CategoriaUseCase.AlmacenUseCase
{
    public class GuardarAlmacenHandler : IRequestHandler<GuardarAlmacenRequest, IResult>
    {
        private readonly IAlmacenRepository _almacenRepository;
        private readonly IMapper _mapper;

        public GuardarAlmacenHandler(IAlmacenRepository almacenRepository, IMapper mapper)
        {
            _almacenRepository = almacenRepository;
            _mapper = mapper;

        }

        public async Task<IResult> Handle(GuardarAlmacenRequest request, CancellationToken cancellationToken)
        {
            var response = new GuardarAlmacenResponse();

            try
            {
                var model = _mapper.Map<Domain.Models.Almacen>(request);
                if (request.EsNuevo)
                {

                    response.Ok = await _almacenRepository.Agregar(model);
                }
                else
                {

                    response.Ok = await _almacenRepository.Modificar(model);
                }
                if (response.Ok)
                {
                    return new SuccessResult<GuardarAlmacenResponse>(response);

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
