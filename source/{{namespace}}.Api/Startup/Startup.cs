using Celerik.NetCore.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using {{namespace}}.Services;

namespace {{namespace}}.Api
{
    /// <summary>
    /// The class containing the startup methods for the application.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Defines the Api Name.
        /// </summary>
        private const string ApiName = "{{spaced-namespace}} SVC";

        /// <summary>
        /// Reference to the current IConfiguration instance.
        /// </summary>
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="config">Reference to the current IConfiguration
        /// instance.</param>
        public Startup(IConfiguration config)
            => _config = config;

        /// <summary>
        /// This method gets called by the runtime. Use this method to add
        /// services to the container.
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of
        /// service descriptors.</param>
        public void ConfigureServices(IServiceCollection services) =>
            MicroserviceStartup.ConfigureServices(services, _config, ApiName, () =>
            {
                services.AddCoreServices(_config);
            });

        /// <summary>
        /// This method gets called by the runtime. Use this method to
        /// configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Provides the mechanisms to configure an
        /// application's request pipeline.</param>
        /// <param name="env">Provides information about the web hosting
        /// environment an application is running in.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => MicroserviceStartup.Configure(app, env, _config, ApiName);
    }
}
