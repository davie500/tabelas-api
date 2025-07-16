using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;
using tech_store_api.Infrastructure.Data;

namespace tech_store_api.Infrastructure.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly AppDbContext _context;

        public FornecedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Fornecedor> ListarTodos()
        {
            return _context.Fornecedor.ToList();
        }

        public Fornecedor ObterPorId(int id)
        {
            return _context.Fornecedor.Find(id);
        }

        public void Adicionar(Fornecedor fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            _context.Fornecedor.Update(fornecedor);
        }

        public void Remover(int id)
        {
            var fornecedor = _context.Fornecedor.Find(id);
            if (fornecedor != null)
                _context.Fornecedor.Remove(fornecedor);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Add(Fornecedor fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
        }
    }
}
