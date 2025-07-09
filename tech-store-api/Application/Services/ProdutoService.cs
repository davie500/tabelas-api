using tech_store_api.Domain.Entities;
using tech_store_api.Domain.Interfaces;

namespace tech_store_api.Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _repo;

        public ProdutoService(IProdutoRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Produto> ObterProdutos()
        {
            return _repo.ListarTodos();
        }

        public Produto CriarProduto(Produto produto)
        {
            _repo.Add(produto);
            return produto;
        }
    }
}
