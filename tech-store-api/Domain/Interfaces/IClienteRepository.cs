using tech_store_api.Domain.Entities;

namespace tech_store_api.Domain.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ListarTodos();

        void Add(Cliente cliente);
        //Produto ObterPorId(int id);
        //void Adicionar(Produto produto);
        //void Atualizar(Produto produto);
        //void Remover(int id);
        //void Salvar(); // Ou SaveChanges()
    }
}