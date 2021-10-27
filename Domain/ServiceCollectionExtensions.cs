using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services
                .AddTransient<ICenterInformationRepository, CenterInformationRepository>();
            
            return services;
        }
        
    }
}