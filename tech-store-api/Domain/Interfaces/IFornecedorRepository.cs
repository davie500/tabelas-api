using tech_store_api.Domain.Entities;

namespace tech_store_api.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        IEnumerable<Fornecedor> ListarTodos();
        void Add(Fornecedor fornecedor);
        Fornecedor ObterPorId(int id);
        //void Update(Fornecedor fornecedor);
        void Atualizar(Fornecedor fornecedor);
        //Produto ObterPorId(int id);
        //void Adicionar(Produto produto);
        //void Atualizar(Produto produto);
        //void Remover(int id);

        void Remover(int id);
        void Salvar(); // Ou SaveChanges()
    }
}
