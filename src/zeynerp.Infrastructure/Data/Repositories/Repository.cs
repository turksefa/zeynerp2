using Microsoft.EntityFrameworkCore;
using zeynerp.Core.Entities;
using zeynerp.Core.Interfaces.Repositories;

namespace zeynerp.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        
        public void Delete(T entity) => _context.Set<T>().Remove(entity);        
    }
}