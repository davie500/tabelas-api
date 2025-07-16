using tech_store_api.Domain.Entities;

namespace tech_store_api.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        IEnumerable<Pagamento> ListarTodos();
        void Add(Pagamento pagamento);
        Pagamento ObterPorId(int id);
        void Atualizar(Pagamento pagamento);
        //Produto ObterPorId(int id);
        //void Adicionar(Produto produto);
        //void Atualizar(Produto produto);
        //void Remover(int id);

        void Remover(int id);
        void Salvar(); // Ou SaveChanges()
    }
}