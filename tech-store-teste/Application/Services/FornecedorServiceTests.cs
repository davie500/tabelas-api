using Moq;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_teste.Test.Application.Services
{
    public class FornecedorServiceTests
    {
        [Fact]
        public void ListarTodos_DeveRetornarListaDeFornecedores()
        {

            var mockRepo = new Mock<IFornecedorRepository>();
            var fornecedoresEsperados = new List<Fornecedor>
                {
                    new Fornecedor { Id = 1, Nome = "Fornecedor 1"},
                    new Fornecedor { Id = 2, Nome = "Fornecedor 2"}
                };

            mockRepo.Setup(repo => repo.ListarTodos()).Returns(fornecedoresEsperados);

            var service = new FornecedorService(mockRepo.Object);

            var resultado = service.ObterFornecedores().ToList();

            // momento de acerto
            //Assert.Equal(9, resultado.Count); //ocorre erro
            Assert.NotEqual(9, resultado.Count);
            Assert.Equal(2, resultado.Count);
            Assert.Contains("Fornecedor 1", resultado[0].Nome);
            Assert.IsType<string>(resultado[0].Nome);
            Assert.Equal("Fornecedor 1", resultado[0].Nome);
        }
    }
}
