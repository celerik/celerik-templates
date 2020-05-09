using Celerik.NetCore.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using {{namespace}}.Services;

namespace {{namespace}}.Test
{
    public class {{main-entity}}BaseTest : BaseTest
    {
        protected override void AddServices(IServiceCollection services)
        {
            var config = GetService<IConfiguration>();
            config["ServiceType"] = "ServiceMock";
            services.AddCoreServices(config);
        }
    }
}
