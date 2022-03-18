﻿using Microsoft.Extensions.DependencyInjection;

namespace UniqueServices.IoC
{
    public static class ServiceRegistrations
    {
        public static IServiceRegistrar Implementation { private get; set; } = new ServiceRegistrar();

        public static IServiceCollection AddTemplateServices(this IServiceCollection services)
        {
            return Implementation.AddTemplateServices(services);
        }
    }
}