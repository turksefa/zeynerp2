using zeynerp.Core.Entities;

namespace zeynerp.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}