using Moq;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_teste.Test.Application.Services
{
    public class ProdutoServiceTests
    {
        [Fact]
        public void ListarTodos_DeveRetornarListaDeProdutos()
        {
            var mockRepo = new Mock<IProdutoRepository>();
            var produtosEsperados = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Produto 1"},
                new Produto { Id = 2, Nome = "Produto 2"}
            };

            mockRepo.Setup(repo => repo.ListarTodos()).Returns(produtosEsperados);

            var service = new ProdutoService(mockRepo.Object);

            var resultado = service.ObterProdutos().ToList();

            // momento de acerto
            //Assert.Equal(9, resultado.Count); //ocorre erro
            Assert.NotEqual(9, resultado.Count);
            Assert.Equal(2, resultado.Count);
            Assert.Contains("Produto 1", resultado[0].Nome);
            Assert.IsType<string>(resultado[0].Nome);
            Assert.Equal("Produto 1", resultado[0].Nome);
        }
    }
}
