using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MiddlewareEngine;

namespace TheApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHost();

            await host.ProcessRequest("Hello, world!");
            await host.ProcessRequest("Buy, world!");
        }

        static Host CreateHost()
        {
            var builder = new HostBuilder();

            builder.AddMiddleware<PerformanceMiddleware>();
            builder.AddMiddleware<DumpRequestMiddleware>();

            builder.ConfigureServices(ConfigureServices);

            var host = builder.Build();
            return host;
        }

        static void ConfigureServices(IServiceCollection services)
        {
        }
    }
}