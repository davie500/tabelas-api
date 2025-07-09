using Microsoft.AspNetCore.Mvc;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_api.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _repo;

        public ClienteService(IClienteRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return _repo.ListarTodos();
        }

        public Cliente CriarCliente(Cliente cliente)
        {
            _repo.Add(cliente);
            return cliente;
        }
    }
}