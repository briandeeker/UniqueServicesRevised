using UniqueServices.DAL.Entities;

namespace UniqueServices.DAL.Repositories
{
    public interface IEmailMessageRepository
    {
        Task AddAsync(EmailMessage emailMessage);
    }
}