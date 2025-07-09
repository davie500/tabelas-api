using Moq;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_teste.Test.Application.Services
{
    public class ClienteServiceTests
    {
        //[Fact]
        //public void ListarTodos_DeveRetornarListaDeCliente()
        //{
        //    var mockRepo = new Mock<IClienteRepository>();
        //    var produtosEsperados = new List<Cliente>
        //    {
        //        new Cliente { Id = 1, Nome = "Cliente 1"},
        //        new Cliente { Id = 2, Nome = "Cliente 2"}
        //    };

        //    mockRepo.Setup(repo => repo.ListarTodos()).Returns(clientesEsperados);

        //    var service = new ClienteService(mockRepo.Object);

        //    var resultado = service.ObterClientes().ToList();

        //    // momento de acerto
        //    //Assert.Equal(9, resultado.Count); //ocorre erro
        //    Assert.NotEqual(9, resultado.Count);
        //    Assert.Equal(2, resultado.Count);
        //    Assert.Contains("Produto 1", resultado[0].Nome);
        //    Assert.IsType<string>(resultado[0].Nome);
        //    Assert.Equal("Produto 1", resultado[0].Nome);
        //}
    }
}