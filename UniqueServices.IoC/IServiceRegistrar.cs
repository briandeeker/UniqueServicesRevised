using Microsoft.Extensions.DependencyInjection;

namespace UniqueServices.IoC
{
    public interface IServiceRegistrar
    {
        IServiceCollection AddTemplateServices(IServiceCollection services);
    }
}