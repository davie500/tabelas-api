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

        public Cliente? ObterClientePorId(int id)
        {
            return _repo.ObterPorId(id);
        }

        public Cliente CriarCliente(Cliente cliente)
        {
            _repo.Add(cliente);
            return cliente;
        }

        public Cliente AtualizarCliente(Cliente cliente)
        {
            _repo.Atualizar(cliente);
            _repo.Salvar(); // Se quiser salvar logo aqui

            return cliente;
        }

        public void RemoverCliente(int id)
        {
            _repo.Remover(id);
            _repo.Salvar();
        }
    }
}