using Celerik.NetCore.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using {{namespace}}.EntityFramework;
using {{namespace}}.Model;

namespace {{namespace}}.Services
{
    public static class ServiceHandler
    {
        public static void AddCoreServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddCoreServices<I{{main-entity}}Service, {{short-namespace}}DbContext>(config)
                .AddAutomapper(config =>
                {
                    config.MapPayloadsToEntities();
                    config.MapEntitiesToDtos();
                })
                .AddValidators(() =>
                {
                    services.AddValidator<Get{{main-entity}}Payload, Get{{main-entity}}Validator>();
                })
                .AddBusinesServices(config =>
                {
                    services.Add{{main-entity}}<I{{main-entity}}Service>(config);
                });
        }
    }
}
