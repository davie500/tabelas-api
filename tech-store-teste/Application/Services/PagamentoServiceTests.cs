using Moq;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_teste.Test.Application.Services
{
    public class PagamentoServiceTests
    {
        [Fact]
        public void ListarTodos_DeveRetornarListaDePagamentos()
        {
            var mockRepo = new Mock<IPagamentoRepository>();
            var pagamentosEsperados = new List<Pagamento>
            {
                new Pagamento { Id = 1, Forma = "Pagamento 1"},
                new Pagamento { Id = 2, Forma = "Pagamento 2"}
            };

            mockRepo.Setup(repo => repo.ListarTodos()).Returns(pagamentosEsperados);

            var service = new PagamentoService(mockRepo.Object);

            var resultado = service.ObterPagamentos().ToList();

            // momento de acerto
            //Assert.Equal(9, resultado.Count); //ocorre erro
            Assert.NotEqual(9, resultado.Count);
            Assert.Equal(2, resultado.Count);
            Assert.Contains("Produto 1", resultado[0].Forma);
            Assert.IsType<string>(resultado[0].Forma);
            Assert.Equal("Produto 1", resultado[0].Forma);
        }
    }
}