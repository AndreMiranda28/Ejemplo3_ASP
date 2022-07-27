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

namespace Almacen.Application.UserCases.ProductoUseCase.FiltrarProductoUseCase
{
    public class FiltrarProductoHandler : IRequestHandler<FiltrarProductoRequest, IResult>
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;
        public FiltrarProductoHandler(IProductoRepository categoriaRepository, IMapper mapper)
        {
            _productoRepository = categoriaRepository;
            _mapper = mapper;

        }
        public async Task<IResult> Handle(FiltrarProductoRequest request, CancellationToken cancellationToken)
        {
            IResult result = null;
            try
            {
                var modelo = await _productoRepository.ObtenerByNombre(request.Nombre,request.id);
                result = new SuccessResult<IEnumerable<FiltrarProductoResponse>>(_mapper.Map<IEnumerable<FiltrarProductoResponse>>(modelo));
                return result;
            }
            catch (Exception ex)
            {
                return new FailureResult();
            }

        }

    }

}
