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

namespace Almacen.Application.UserCases.CategoriaUseCase.GuardarCategoriaUseCase
{
    public class GuardarCategoriaHandler : IRequestHandler<GuardarCategoriaRequest, IResult>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public GuardarCategoriaHandler(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;

        }
        public async Task<IResult> Handle(GuardarCategoriaRequest request, CancellationToken cancellationToken)
        {
            var response = new GuardarCategoriaResponse();

            try
            {
                var model = _mapper.Map<Categoria>(request);
                if (request.EsNuevo)
                {
                   
                    response.Ok = await _categoriaRepository.Agregar(model);    
                }
                else
                {
                    
                    response.Ok = await _categoriaRepository.Modificar(model);
                }
                if (response.Ok)
                {
                    return new SuccessResult<GuardarCategoriaResponse>(response);

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
