using System.Diagnostics.CodeAnalysis;
using Celerik.NetCore.Services;
using Celerik.NetCore.Util;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace {{namespace}}.Services
{
    public static class {{main-entity}}ServiceInjector
    {
        [ExcludeFromCodeCoverage]
        public static void Add{{main-entity}}<TLoggerCategory>(
            this IServiceCollection services,
            IConfiguration config)
        {
            var serviceType = config.GetServiceType();

            switch (serviceType)
            {
                case ApiServiceType.ServiceEF:
                    services.AddTransient<I{{main-entity}}Service, {{main-entity}}ServiceEF<TLoggerCategory>>();
                    break;
                case ApiServiceType.ServiceMock:
                    services.AddTransient<I{{main-entity}}Service, {{main-entity}}ServiceMock<TLoggerCategory>>();
                    break;
                default:
                    throw new InjectException(
                        UtilResources.Get("Common.InjectException",
                        nameof(I{{main-entity}}Service))
                    );
            }
        }
    }
}
