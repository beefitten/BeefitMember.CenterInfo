using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using Persistence.Settings;

namespace Persistence.Setup
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services
                .AddTransient<IDatabaseSettings, CenterInformationSetup>()
                .AddTransient<ICenterInformationRepository, CenterInformationRepository>();

            return services;
        }
    }
}