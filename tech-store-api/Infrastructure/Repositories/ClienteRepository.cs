using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;
using tech_store_api.Infrastructure.Data;

namespace tech_store_api.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _context.Cliente.ToList();
        }

        public Cliente ObterPorId(int id)
        {
            return _context.Cliente.Find(id);
        }

        public void Adicionar(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
        }

        public void Remover(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente != null)
                _context.Cliente.Remove(cliente);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Add(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }
    }
}
