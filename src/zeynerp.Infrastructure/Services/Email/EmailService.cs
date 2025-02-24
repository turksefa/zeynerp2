using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using zeynerp.Core.Interfaces.Services;

namespace zeynerp.Infrastructure.Services.Email
{
    public class EmailService : IEmailService, IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sturk", "sefa.turk@smak.com.tr"));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = subject;
            message.Body = new TextPart("html") { Text = htmlMessage };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.turkticaret.net", 587, SecureSocketOptions.StartTls);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.AuthenticateAsync("sefa.turk@smak.com.tr", "Sefa.2020");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendActivationEmailAsync(string email, string callbackUrl)
        {
            await SendEmailAsync(email, "Activate your account", $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>.");
        }

        public async Task SendInvitationEmailAsync(string email, string inviteToken, string companyName)
        {
            await SendEmailAsync(email, "You have been invited to join Zeynerp", $"You have been invited to join {companyName} on Zeynerp. Please <a href='http://localhost:5000/Account/Invite?token={inviteToken}'>click here</a> to accept the invitation.");
        }

        public async Task SendPasswordResetEmailAsync(string email, string callbackUrl)
        {
            await SendEmailAsync(email, "Reset your password", $"Please reset your password by <a href='{callbackUrl}'>clicking here</a>.");
        }
    }
}