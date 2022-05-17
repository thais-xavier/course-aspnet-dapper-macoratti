using Xavier.Dapper.Api.Data;

namespace Xavier.Dapper.Api.Repositories
{
    public interface ITarefaRepository
    {
         Task<List<Tarefa>> GetTarefasAsync();
         Task<Tarefa> GetTarefaByIdAsync(int id);
         Task<TarefaContainer> GetTarefasEContadorAsync();
         Task<int> SaveAsync(Tarefa novaTarefa);
         Task<int> UpdateTarefaStatusAsync(Tarefa atualizaTarefa);
         Task<int> DeleteAsync(int id);
    }
}