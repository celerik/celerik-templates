using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace {{namespace}}.Api
{
    /// <summary>
    /// Application entry class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Application entry method.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        /// <summary>
        /// Initializes a new instance of the HostBuilder class with
        /// custom configuration.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>The IHostBuilder for chaining.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
