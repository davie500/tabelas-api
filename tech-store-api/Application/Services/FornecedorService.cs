using Microsoft.AspNetCore.Mvc;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_api.Application.Services
{
    public class FornecedorService
    {
        private readonly IFornecedorRepository _repo;

        public FornecedorService(IFornecedorRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Fornecedor> ObterFornecedores()
        {
            return _repo.ListarTodos();
        }

        public Fornecedor? ObterFornecedorPorId(int id)
        {
            return _repo.ObterPorId(id);
        }

        public Fornecedor CriarFornecedor(Fornecedor fornecedor)
        {
            _repo.Add(fornecedor);
            return fornecedor;
        }

        public Fornecedor AtualizarFornecedor(Fornecedor fornecedor)
        {
            _repo.Atualizar(fornecedor);
            _repo.Salvar(); // Se quiser salvar logo aqui

            return fornecedor;
        }

        public void RemoverFornecedor(int id)
        {
            _repo.Remover(id);
            _repo.Salvar();
        }
    }
}