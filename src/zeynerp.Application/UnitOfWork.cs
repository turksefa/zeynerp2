using zeynerp.Core.Interfaces;
using zeynerp.Core.Interfaces.Repositories;
using zeynerp.Infrastructure.Data;

namespace zeynerp.Application
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ICompanyRepository _companyRepository;

        public UnitOfWork(ApplicationDbContext context, ICompanyRepository companyRepository)
        {
            _context = context;
            _companyRepository = companyRepository;
        }

        public ICompanyRepository CompanyRepository => _companyRepository;

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}