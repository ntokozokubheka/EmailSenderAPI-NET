using EmailSenderAPI.Models;


namespace EmailSenderAPI.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
