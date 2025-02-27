using zeynerp.Core.DTOs.Companies;
using zeynerp.Core.Entities;

namespace zeynerp.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<CompanyDto> CreateCompanyAsync(Company company);
        Task<UserInvitation> InviteUserAsync(int companyId, string email);
    }
}