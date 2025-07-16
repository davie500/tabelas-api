using Microsoft.AspNetCore.Mvc;
using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_api.Application.Services
{
    public class PagamentoService
    {
        private readonly IPagamentoRepository _repo;

        public PagamentoService(IPagamentoRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Pagamento> ObterPagamentos()
        {
            return _repo.ListarTodos();
        }

        public Pagamento? ObterPagamentoPorId(int id)
        {
            return _repo.ObterPorId(id);
        }

        public Pagamento CriarPagamento(Pagamento pagamento)
        {
            _repo.Add(pagamento);
            return pagamento;
        }

        public Pagamento AtualizarPagamento(Pagamento pagamento)
        {
            _repo.Atualizar(pagamento);
            _repo.Salvar(); // Se quiser salvar logo aqui

            return pagamento;
        }

        public void RemoverPagamento(int id)
        {
            _repo.Remover(id);
            _repo.Salvar();
        }
    }
}