using System;
using Xunit;
using NSubstitute;
using Almacen.Domain.Repositories;
using Almacen.Application.UserCases.CategoriaUseCase.AlmacenUseCase;
using System.Threading.Tasks;
using Moq;
using System.Threading;
using AutoMapper;
using Almacen.Domain.Models;
namespace Almacen.Tests
{
    public class GuardarAlmacenTest
    {
        private readonly IAlmacenRepository categoriaRepository;
        private readonly IMapper mapper;
        private readonly GuardarAlmacenHandler guardarAlmacenTest;
        public GuardarAlmacenTest()
        {
            categoriaRepository = Substitute.For<IAlmacenRepository>();
            mapper = Substitute.For<IMapper>();
            guardarAlmacenTest = Substitute.ForPartsOf<GuardarAlmacenHandler>(categoriaRepository, mapper);
        }
        [Fact]
        public async Task GuardarCategoriaEscenarioOk()
        {
            var request = new GuardarAlmacenRequest()
            {
                EsNuevo = true,
                Nombre = "Almacen de prueba 2"
            };

            var almacenModel = new Domain.Models.Almacen()
            {
                Nombre = "Almacen de prueba 2"
            };

            mapper.Map<Domain.Models.Almacen>(request).Returns(almacenModel);


            categoriaRepository.Agregar(almacenModel).Returns(true);

            var response = await guardarAlmacenTest.Handle(request, It.IsAny<CancellationToken>());

            Assert.True(response.HasSucceeded == true);
        }
    }

}
