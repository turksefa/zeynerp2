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

        public async Task<CompanyDto> CreateCompanyAsync(Company company)
        {
            await _unitOfWork.CompanyRepository.AddAsync(_mapper.Map<Company>(company));
            return _mapper.Map<CompanyDto>(company);
        }

        public async Task<UserInvitation> InviteUserAsync(int companyId, string email)
        {
            var company = await _unitOfWork.CompanyRepository.GetByIdAsync(companyId);
            if (company == null)
            
                throw new Exception(nameof(Company));
            
            var invitation = new UserInvitation
            {
                CompanyId = companyId,
                Email = email,
                Token = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                IsAccepted = false
            };

            await _unitOfWork.CompanyRepository.AddInvitationAsync(invitation);
        }
    }
}