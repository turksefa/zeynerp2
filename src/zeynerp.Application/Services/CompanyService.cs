using AutoMapper;
using zeynerp.Core.DTOs.Companies;
using zeynerp.Core.Entities;
using zeynerp.Core.Interfaces;
using zeynerp.Core.Interfaces.Services;

namespace zeynerp.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CompanyDto> CreateCompanyAsync(string companyName)
        {
            await _unitOfWork.CompanyRepository.AddAsync(_mapper.Map<Company>(companyName));
        }

        public Task<UserInvitation> InviteUserAsync(int companyId, string email)
        {
            throw new NotImplementedException();
        }
    }
}