namespace ApiDeTarefas.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> SearchById(params object[] keys);
        Task<T> GetById(params object[] keys);
        Task<ICollection<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity, params object[] keys);
        Task<T> Delete(params object[] keys);
    }
}
