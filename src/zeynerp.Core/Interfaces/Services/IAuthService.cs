namespace zeynerp.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<(bool Success, string[] Errors)> RegisterAsync(string email, string password);
        Task<(bool Success, string[] Errors)> LoginAsync(string email, string password);
        Task LogoutAsync();
    }
}