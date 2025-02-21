using zeynerp.Core.Interfaces.Repositories;

namespace zeynerp.Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICompanyRepository CompanyRepository { get; }
        Task SaveChangesAsync();
    }
}