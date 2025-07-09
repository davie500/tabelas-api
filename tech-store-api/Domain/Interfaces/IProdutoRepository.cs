using tech_store_api.Domain.Entities;

namespace tech_store_api.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ListarTodos();

        void Add (Produto produto);
        //Produto ObterPorId(int id);
        //void Adicionar(Produto produto);
        //void Atualizar(Produto produto);
        //void Remover(int id);
        //void Salvar(); // Ou SaveChanges()
    }
}
