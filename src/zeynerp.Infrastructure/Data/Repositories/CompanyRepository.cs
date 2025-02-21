using zeynerp.Core.Entities;
using zeynerp.Core.Interfaces.Repositories;

namespace zeynerp.Infrastructure.Data.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}