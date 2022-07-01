using System;
using Xunit;
using NSubstitute;
using Almacen.Domain.Repositories;
using Almacen.Application.UserCases.CategoriaUseCase.GuardarCategoriaUseCase;
using System.Threading.Tasks;
using Moq;
using System.Threading;
using AutoMapper;
using Almacen.Domain.Models;

namespace Almacen.Tests
{
    public class GuardarCategoriaTest
    {
        private readonly ICategoriaRepository categoriaRepository;
        private readonly IMapper mapper;
        private readonly GuardarCategoriaHandler guardarCategoriaTest;

        public GuardarCategoriaTest()
        {
            categoriaRepository = Substitute.For<ICategoriaRepository>();
            mapper = Substitute.For<IMapper>();
            guardarCategoriaTest = Substitute.ForPartsOf<GuardarCategoriaHandler>(categoriaRepository, mapper);
        }
        [Fact]
        public async Task GuardarCategoriaEscenarioOk()
        {
            var request = new GuardarCategoriaRequest()
            {
                EsNuevo = true,
                Nombre="Categoria de prueba 2"
            };

            var categoriaModel = new Categoria()
            {
                Nombre = "Categoria de prueba 02"
            };

            mapper.Map<Categoria>(request).Returns(categoriaModel);


            categoriaRepository.Agregar(categoriaModel).Returns(true);

            var response = await guardarCategoriaTest.Handle(request, It.IsAny<CancellationToken>());

            Assert.True(response.HasSucceeded==true);
        }

        [Fact]
        public async Task EditarCategoriaEscenarioOk()
        {
            var request = new GuardarCategoriaRequest()
            {
                EsNuevo = false,
                IdCategoria=1,
            };

            var categoriaModel = new Categoria();
            mapper.Map<Categoria>(request).Returns(categoriaModel);


            categoriaRepository.Modificar(categoriaModel).Returns(true);

            var response = await guardarCategoriaTest.Handle(request, It.IsAny<CancellationToken>());

            Assert.True(response.HasSucceeded == true);
        }
    }
}
