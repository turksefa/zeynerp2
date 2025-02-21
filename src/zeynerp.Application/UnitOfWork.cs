using zeynerp.Core.Interfaces;
using zeynerp.Infrastructure.Data;

namespace zeynerp.Application
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}