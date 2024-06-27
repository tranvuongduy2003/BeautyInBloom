using BeautyInBloom.Models.Models;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IEmailService
{
    Task SendMail(MailContent mailContent);

    Task SendEmailAsync(string email, string subject, string htmlMessage);
}