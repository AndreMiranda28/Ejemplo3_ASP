using Almacen.Application.Common;
using Almacen.Domain.Models;
using Almacen.Domain.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Almacen.Application.UserCases.CategoriaUseCase.FiltrarCategoriaUseCase
{
    public class FiltrarCategoríaHandler : IRequestHandler<FiltrarCategoriaRequest, IResult>
    {

        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        public FiltrarCategoríaHandler(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;

        }
        public async Task<IResult> Handle(FiltrarCategoriaRequest request, CancellationToken cancellationToken)
        {
            IResult result = null;
            try
            {
                var modelo = await _categoriaRepository.ObtenerByNombre(request.Nombre);
                result = new SuccessResult<IEnumerable< FiltrarCategoriaResponse >> (_mapper.Map< IEnumerable < FiltrarCategoriaResponse >> (modelo));
                return result;
            }
            catch (Exception ex)
            {
                return new FailureResult();
            }

        }
    }
}
