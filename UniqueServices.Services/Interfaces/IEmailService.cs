using UniqueServices.Services.Types;

namespace UniqueServices.Services.Interfaces
{
    public interface IEmailService
    {
        public Task SendEmailAsync(EmailMessage emailMessage);
    }
}