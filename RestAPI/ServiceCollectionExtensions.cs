using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace RestAPI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRestAPI(this IServiceCollection services)
        {
            services
                .AddTransient<ICenterInformationService, CenterInformationService>();

            return services;
        }
    }
}