using zeynerp.Core.Interfaces.Services;

namespace zeynerp.Application.Services
{
    public class AuthService : IAuthService
    {
        public Task<(bool Success, string[] Errors)> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(bool Success, string[] Errors)> RegisterAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}