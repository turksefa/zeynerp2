namespace zeynerp.Core.Interfaces.Services
{
    public interface IEmailService
    {
        Task SendActivationEmailAsync(string email, string callbackUrl);
        Task SendInvitationEmailAsync(string email, string inviteToken, string companyName);
        Task SendPasswordResetEmailAsync(string email, string callbackUrl);
    }
}