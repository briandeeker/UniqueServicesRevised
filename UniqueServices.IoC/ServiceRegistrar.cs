using UniqueServices.DAL.Context;
using UniqueServices.DAL.Repositories;
using UniqueServices.Services.Implementations;
using UniqueServices.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace UniqueServices.IoC
{
    public class ServiceRegistrar : IServiceRegistrar
    {
        public IServiceCollection AddTemplateServices(IServiceCollection services)
        {
            return services
                .AddDbContext<TemplateDbContext>()
                .AddScoped<IEmailMessageRepository, EmailMessageRepository>()
                .AddScoped<IEmailService, EmailService>();
        }
    }
}