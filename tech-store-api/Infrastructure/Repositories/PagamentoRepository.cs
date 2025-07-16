using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;
using tech_store_api.Infrastructure.Data;

namespace tech_store_api.Infrastructure.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly AppDbContext _context;

        public PagamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pagamento> ListarTodos()
        {
            return _context.Pagamento.ToList();
        }

        public Pagamento ObterPorId(int id)
        {
            return _context.Pagamento.Find(id);
        }

        public void Adicionar(Pagamento pagamento)
        {
            _context.Pagamento.Add(pagamento);
        }

        public void Atualizar(Pagamento pagamento)
        {
            _context.Pagamento.Update(pagamento);
        }

        public void Remover(int id)
        {
            var pagamento = _context.Pagamento.Find(id);
            if (pagamento != null)
                _context.Pagamento.Remove(pagamento);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Add(Pagamento pagamento)
        {
            _context.Pagamento.Add(pagamento);
            _context.SaveChanges();
        }
    }
}
